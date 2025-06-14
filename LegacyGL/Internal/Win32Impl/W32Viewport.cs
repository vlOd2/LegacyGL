﻿// Copyright (c) vlOd
// Licensed under the GNU Lesser General Public License, version 3.0

using System.Collections.Concurrent;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using LegacyGL.Internal.Win32Impl.Native;
using LegacyGL.Internal.Win32Impl.Native.Const;
using LegacyGL.Internal.Win32Impl.Native.Structs;
using static LegacyGL.Internal.Win32Impl.Native.Const.W32ConstCS;
using static LegacyGL.Internal.Win32Impl.Native.Const.W32ConstGCLP;
using static LegacyGL.Internal.Win32Impl.Native.Const.W32ConstGWL;
using static LegacyGL.Internal.Win32Impl.Native.Const.W32ConstIDC;
using static LegacyGL.Internal.Win32Impl.Native.Const.W32ConstPFD;
using static LegacyGL.Internal.Win32Impl.Native.Const.W32ConstPM;
using static LegacyGL.Internal.Win32Impl.Native.Const.W32ConstSW;
using static LegacyGL.Internal.Win32Impl.Native.Const.W32ConstSWP;
using static LegacyGL.Internal.Win32Impl.Native.Const.W32ConstWM;
using static LegacyGL.Internal.Win32Impl.Native.Const.W32ConstWS;
using static LegacyGL.Internal.Win32Impl.Native.Const.W32ConstWGLARB;
using static LegacyGL.Internal.Win32Impl.Native.W32Painting;
using static LegacyGL.Internal.Win32Impl.Native.W32PixelFormat;
using static LegacyGL.Internal.Win32Impl.Native.W32WGL;
using static LegacyGL.Internal.Win32Impl.Native.W32Windowing;
using static LegacyGL.Internal.Win32Impl.Native.Win32;
using LegacyGL.Bindings;

namespace LegacyGL.Internal.Win32Impl;

internal unsafe class W32Viewport : IDisposable
{
    private const string CLASS_NAME = "LegacyGLWnd";
    private const uint WINDOW_STYLES = WS_OVERLAPPEDWINDOW & ~WS_THICKFRAME & ~WS_MAXIMIZEBOX & ~WS_VISIBLE;
    private nint moduleHandle;
    private WNDCLASS wndClass;
    public nint Handle;
    private bool shownAfterInit;
    private nint icon;
    private nint deviceContext;
    private nint wglContext;
    public readonly ConcurrentQueue<W32KBEvent> KeyboardEvents = [];
    public bool CursorHidden;
    public short ScrollWheel;
    public RECT WindowRect;
    public RECT ClientRect;
    #region Properties
    private int windowStyles => GetWindowLongA(Handle, GWL_STYLE);
    public Size ClientSize
    {
        get => new(ClientRect.right, ClientRect.bottom);
        set
        {
            RECT rect = new()
            {
                right = value.Width,
                bottom = value.Height
            };
            AdjustWindowRect(ref rect, windowStyles, false);
            int w = rect.right - rect.left;
            int h = rect.bottom - rect.top;
            ClientRect.right = w;
            ClientRect.bottom = h;
            SetWindowPos(Handle, 0, 0, 0, w, h, SWP_NOZORDER | SWP_NOMOVE);
        }
    }
    public string Title
    {
        get
        {
            StringBuilder builder = new(255);
            _ = GetWindowTextA(Handle, builder, 255);
            return builder.ToString();
        }
        set => SetWindowTextA(Handle, value);
    }
    public nint Icon
    {
        get => icon;
        set => icon = SetClassLongA(Handle, GCLP_HICON, (int)value);
    }
    public bool ShouldClose { get; private set; }
    public bool Focused { get; private set; }
    public bool Resizable
    {
        get => (GetWindowLongA(Handle, GWL_STYLE) & WS_THICKFRAME) == WS_THICKFRAME;
        set
        {
            if (!value)
            {
                int style = GetWindowLongA(Handle, GWL_STYLE);
                style &= ~WS_MAXIMIZEBOX;
                style &= ~WS_THICKFRAME;
                _ = SetWindowLongA(Handle, GWL_STYLE, style);
            }
            else
            {
                int style = GetWindowLongA(Handle, GWL_STYLE);
                style |= WS_MAXIMIZEBOX;
                style |= WS_THICKFRAME;
                _ = SetWindowLongA(Handle, GWL_STYLE, style);
            }

            SetWindowPos(Handle, 0, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE | SWP_NOZORDER | SWP_FRAMECHANGED);
        }
    }
    #endregion

    public bool CreateWindow()
    {
        moduleHandle = Marshal.GetHINSTANCE(typeof(W32Viewport).Module);

        wndClass = new WNDCLASS()
        {
            style = CS_HREDRAW | CS_VREDRAW | CS_OWNDC,
            lpfnWndProc = WndProc,
            hInstance = moduleHandle,
            lpszClassName = CLASS_NAME,
            hCursor = LoadCursorA(0, IDC_ARROW)
        };

        if (RegisterClassA(ref wndClass) == 0)
        {
            Dispose();
            LGL.ErrorLogHandler("Could not create window class");
            return false;
        }

        Handle = CreateWindowExA(0, CLASS_NAME, "Game", WINDOW_STYLES,
            CW_USEDEFAULT, CW_USEDEFAULT,
            LGL.DEFAULT_WIDTH, LGL.DEFAULT_HEIGHT,
            0, 0, moduleHandle, 0);

        if (Handle == 0)
        {
            Dispose();
            LGL.ErrorLogHandler("Could not create window");
            return false;
        }

        UpdateRects();
        deviceContext = GetDC(Handle);

        if (deviceContext == 0)
        {
            Dispose();
            LGL.ErrorLogHandler("Could not create device context");
            return false;
        }

        return true;
    }

    private nint CreateBasicWGLContext()
    {
        nint context = wglCreateContext(deviceContext);

        if (context == 0)
        {
            LGL.ErrorLogHandler("Could not create context");
            return 0;
        }

        if (!wglMakeCurrent(deviceContext, context))
        {
            LGL.ErrorLogHandler("Could not make context current");
            return 0;
        }

        return context;
    }

    private nint CreateExtWGLContext(ref ContextRequest ctxReq, wglCreateContextAttribsARB createContextARB)
    {
        List<int> attrib = [
            WGL_CONTEXT_MAJOR_VERSION_ARB, ctxReq.GLMajorVer,
            WGL_CONTEXT_MINOR_VERSION_ARB, ctxReq.GLMinorVer
        ];
        attrib.Add(WGL_CONTEXT_PROFILE_MASK_ARB);
        if (ctxReq.GLES)
            attrib.Add(WGL_CONTEXT_ES2_PROFILE_BIT_EXT);
        else if (ctxReq.Core)
            attrib.Add(WGL_CONTEXT_CORE_PROFILE_BIT_ARB);
        else
            attrib.Add(WGL_CONTEXT_COMPATIBILITY_PROFILE_BIT_ARB);
        attrib.Add(0x00); // End of attributes

        nint context = createContextARB(deviceContext, 0, [.. attrib]);
        if (context == 0)
        {
            LGL.ErrorLogHandler("Could not create context");
            return 0;
        }

        if (!wglMakeCurrent(deviceContext, context))
        {
            LGL.ErrorLogHandler("Could not make context current");
            return 0;
        }

        return context;
    }

    public bool CreateContext(ref ContextRequest ctxReq, W32NativeAPILoader loader)
    {
        PIXELFORMATDESCRIPTOR pixelFormat = new()
        {
            nSize = SizeOf<PIXELFORMATDESCRIPTOR>(),
            nVersion = 1,
            dwFlags = PFD_DRAW_TO_WINDOW | PFD_SUPPORT_OPENGL | PFD_DOUBLEBUFFER,
            iPixelType = PFD_TYPE_RGBA,
            cColorBits = ctxReq.ColorBits,
            cDepthBits = ctxReq.DepthBits,
            cStencilBits = ctxReq.StencilBits,
            iLayerType = PFD_MAIN_PLANE
        };

        int format = ChoosePixelFormat(deviceContext, ref pixelFormat);
        if (format == 0)
        {
            LGL.ErrorLogHandler("Could not find a matching pixel format");
            return false;
        }

        if (!SetPixelFormat(deviceContext, format, ref pixelFormat))
        {
            LGL.ErrorLogHandler("Could not set the pixel format");
            return false;
        }

        nint tempContext = CreateBasicWGLContext();
        if (tempContext == 0)
            return false;
        wglCreateContextAttribsARB createContextARB = loader.LoadDelegateGL<wglCreateContextAttribsARB>("wglCreateContextAttribsARB");
        wglDeleteContext(tempContext);

        if (createContextARB == null)
        {
            if (ctxReq.Core || ctxReq.GLES)
            {
                LGL.ErrorLogHandler("No WGL context extension, cannot satisfy context request");
                return false;
            }
            wglContext = CreateBasicWGLContext();
        }
        else
            wglContext = CreateExtWGLContext(ref ctxReq, createContextARB);

        return LoadGLAPI(ref ctxReq, loader);
    }

    // This also loads the GL API bindings
    private bool LoadGLAPI(ref ContextRequest ctxReq, W32NativeAPILoader loader)
    {
        if (wglContext == 0)
            return false;
        GLLoader.Load(loader, ctxReq.GLES);

        byte* versionPtr = GL10.glGetString(GL10.GL_VERSION);
        if (versionPtr == null)
        {
            LGL.ErrorLogHandler("Created context is fucky wacky, throw your GPU in the dumpster");
            return false;
        }

        (int, int) version = LGL.ParseGLVersion(new LGLString(versionPtr));
        if (version.Item1 < ctxReq.GLMajorVer || (version.Item1 == ctxReq.GLMajorVer && version.Item2 < ctxReq.GLMinorVer))
        {
            LGL.ErrorLogHandler("Created context version does not satisfy context request");
            return false;
        }

        return true;
    }

    private void UpdateRects()
    {
        WindowRect = new();
        ClientRect = new();
        GetWindowRect(Handle, ref WindowRect);
        GetClientRect(Handle, ref ClientRect);
    }

    public void Center()
    {
        int sw = GetSystemMetrics(W32ConstSM.SM_CXSCREEN);
        int sh = GetSystemMetrics(W32ConstSM.SM_CYSCREEN);
        int w = WindowRect.right - WindowRect.left;
        int h = WindowRect.bottom - WindowRect.top;
        int x = sw / 2 - w / 2;
        int y = sh / 2 - h / 2;
        SetWindowPos(Handle, 0, x, y, w, h, SWP_NOZORDER | SWP_NOSIZE);
    }

    public void Poll()
    {
        if (!shownAfterInit)
        {
            shownAfterInit = true;
            ShowWindow(Handle, SW_SHOW);
            UpdateWindow(Handle);
        }
        MSG msg = new();
        if (PeekMessageA(ref msg, 0, 0, 0, PM_REMOVE))
        {
            TranslateMessage(ref msg);
            DispatchMessageA(ref msg);
        }
    }

    public void Swap() => SwapBuffers(deviceContext);

    private void PutKBEvent(bool state, short vk, byte sc, bool repeat)
        => KeyboardEvents.Enqueue(new W32KBEvent()
        {
            State = state,
            VK = vk,
            SC = sc,
            Repeat = repeat
        });

    private nint WndProc(nint hWnd, uint uMsg, nint wParam, nint lParam)
    {
        switch (uMsg)
        {
            case WM_PAINT:
                {
                    PAINTSTRUCT paintStruct = new();
                    BeginPaint(hWnd, ref paintStruct);
                    EndPaint(hWnd, ref paintStruct);
                    break;
                }

            case WM_CLOSE:
                ShouldClose = true;
                break;

            case WM_KEYDOWN:
                {
                    short vk = (short)(long)wParam;
                    int keyInfo = (int)(long)lParam;
                    byte sc = (byte)((keyInfo >> 16) & 0xFF);
                    bool repeat = (keyInfo & (1 << 30)) > 0;
                    PutKBEvent(true, vk, sc, repeat);
                    break;
                }

            case WM_KEYUP:
                {
                    short vk = (short)(long)wParam;
                    int keyInfo = (int)(long)lParam;
                    byte sc = (byte)((keyInfo >> 16) & 0xFF);
                    bool repeat = (keyInfo & (1 << 30)) > 0;
                    PutKBEvent(false, vk, sc, repeat);
                    break;
                }

            case WM_SETCURSOR:
                if (CursorHidden)
                {
                    SetCursor(0);
                    break;
                }
                goto default;

            case WM_SETFOCUS:
                Focused = true;
                break;

            case WM_KILLFOCUS:
                Focused = false;
                break;

            case WM_MOUSEWHEEL:
                ScrollWheel = HIWORD(wParam);
                break;

            case WM_WINDOWPOSCHANGED:
                {
                    WINDOWPOS* ptr = (WINDOWPOS*)lParam;

                    bool isMove = (ptr->flags & SWP_NOMOVE) == 0;
                    bool isResize = (ptr->flags & SWP_NOSIZE) == 0;
                    if (!isMove && !isResize)
                        break;

                    if (isMove)
                    {
                        WindowRect.left = ptr->x;
                        WindowRect.top = ptr->y;
                    }

                    if (isResize)
                    {
                        WindowRect.right = ptr->w + ptr->x;
                        WindowRect.bottom = ptr->h + ptr->y;
                        GetClientRect(Handle, ref ClientRect);
                    }

                    break;
                }

            default:
                return DefWindowProcA(hWnd, uMsg, wParam, lParam);
        }

        return 0;
    }

    public void Dispose()
    {
        KeyboardEvents.Clear();

        if (wglContext != 0)
            wglDeleteContext(wglContext);
        if (deviceContext != 0)
            _ = ReleaseDC(Handle, deviceContext);
        if (Handle != 0)
        {
            DestroyWindow(Handle);
            UnregisterClassA(CLASS_NAME, moduleHandle);
        }
        GLLoader.Unload();

        // TODO: Call this somewhere
        // Right now it fucks up msg boxes so keep it disabled for now
        //PostQuitMessage(0);

        wglContext = 0;
        deviceContext = 0;
        Handle = 0;
        moduleHandle = 0;
    }
}
