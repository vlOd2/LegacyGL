// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

using LegacyGL.Internal.Win32Impl.Native;
using LegacyGL.Internal.Win32Impl.Native.Const;
using LegacyGL.Internal.Win32Impl.Native.Structs;
using System.Collections.Concurrent;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
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
using static LegacyGL.Internal.Win32Impl.Native.W32Painting;
using static LegacyGL.Internal.Win32Impl.Native.W32PixelFormat;
using static LegacyGL.Internal.Win32Impl.Native.W32WGL;
using static LegacyGL.Internal.Win32Impl.Native.W32Windowing;
using static LegacyGL.Internal.Win32Impl.Native.Win32;

namespace LegacyGL.Internal.Win32Impl;

internal class W32Viewport : IDisposable
{
    private const string CLASS_NAME = "LegacyGLWnd";
    #region WGL ARB Constants
    private const int WGL_CONTEXT_MAJOR_VERSION_ARB = 0x2091;
    private const int WGL_CONTEXT_MINOR_VERSION_ARB = 0x2092;
    private const int WGL_CONTEXT_LAYER_PLANE_ARB = 0x2093;
    private const int WGL_CONTEXT_FLAGS_ARB = 0x2094;
    private const int WGL_CONTEXT_PROFILE_MASK_ARB = 0x9126;
    private const int WGL_CONTEXT_DEBUG_BIT_ARB = 0x0001;
    private const int WGL_CONTEXT_FORWARD_COMPATIBLE_BIT_ARB = 0x0002;
    private const int WGL_CONTEXT_CORE_PROFILE_BIT_ARB = 0x00000001;
    private const int WGL_CONTEXT_COMPATIBILITY_PROFILE_BIT_ARB = 0x00000002;
    #endregion
    private WNDCLASS wndClass;
    public nint Handle;
    private nint icon;
    private nint deviceContext;
    private nint glContext;
    public readonly ConcurrentQueue<W32KBEvent> KeyboardEvents = [];
    public bool CursorHidden;
    public float ScrollWheel;
    #region Properties
    public bool HasGLContext => glContext != NULLPTR;
    public Point Position
    {
        get
        {
            RECT rect = new RECT();
            GetWindowRect(Handle, ref rect);
            int x = rect.left;
            int y = rect.top;
            return new Point(x, y);
        }
    }
    public Size Size
    {
        get
        {
            RECT rect = new RECT();
            GetWindowRect(Handle, ref rect);
            int w = rect.right - rect.left;
            int h = rect.bottom - rect.top;
            return new Size(w, h);
        }
    }
    public Size ClientSize
    {
        get
        {
            RECT rect = new RECT();
            GetClientRect(Handle, ref rect);
            // Client rect should always be at 0,0
            // but let's play it safe
            int w = rect.right - rect.left;
            int h = rect.bottom - rect.top;
            return new Size(w, h);
        }
        set
        {
            RECT wndRect = new RECT();
            GetWindowRect(Handle, ref wndRect);

            int x = wndRect.left;
            int y = wndRect.top;

            RECT rect = new RECT()
            {
                right = value.Width,
                bottom = value.Height
            };
            AdjustWindowRect(ref rect, GetWindowLongA(Handle, GWL_STYLE), false);

            int w = rect.right - rect.left;
            int h = rect.bottom - rect.top;
            SetWindowPos(Handle, NULLPTR, x, y, w, h, SWP_SHOWWINDOW | SWP_NOZORDER | SWP_NOMOVE);
        }
    }
    public string Title
    {
        get
        {
            StringBuilder builder = new StringBuilder(255);
            GetWindowTextA(Handle, builder, 255);
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
            RECT rect = new RECT();
            GetWindowRect(Handle, ref rect);

            int x = rect.left;
            int y = rect.top;
            int w = rect.right - rect.left;
            int h = rect.bottom - rect.top;

            if (!value)
            {
                int style = GetWindowLongA(Handle, GWL_STYLE);
                style &= ~WS_MAXIMIZEBOX;
                style &= ~WS_THICKFRAME;
                SetWindowLongA(Handle, GWL_STYLE, style);
            }
            else
            {
                int style = GetWindowLongA(Handle, GWL_STYLE);
                style |= WS_MAXIMIZEBOX;
                style |= WS_THICKFRAME;
                SetWindowLongA(Handle, GWL_STYLE, style);
            }

            SetWindowPos(Handle, NULLPTR, x, y, w, h, SWP_SHOWWINDOW);
        }
    }
    #endregion

    public W32Viewport()
    {
        nint module = Marshal.GetHINSTANCE(typeof(W32Viewport).Module);
        wndClass = new WNDCLASS()
        {
            style = CS_HREDRAW | CS_VREDRAW | CS_OWNDC,
            lpfnWndProc = WndProc,
            hInstance = module,
            lpszClassName = CLASS_NAME,
            hCursor = LoadCursorA(NULLPTR, IDC_ARROW)
        };

        if (RegisterClassA(ref wndClass) == 0)
            throw new GLException("RegisterClassA");

        Handle = CreateWindowExA(0, CLASS_NAME, "Game",
            WS_OVERLAPPEDWINDOW & ~WS_THICKFRAME & ~WS_MAXIMIZEBOX,
            CW_USEDEFAULT, CW_USEDEFAULT, 800, 600,
            NULLPTR, NULLPTR, module, NULLPTR);

        if (Handle == NULLPTR)
            throw new GLException("CreateWindowExA");

        ShowWindow(Handle, SW_NORMAL);
        UpdateWindow(Handle);
    }

    #region Setup functions
    public static PIXELFORMATDESCRIPTOR BuildPixelFormat()
    {
        PIXELFORMATDESCRIPTOR pixelFormat = new PIXELFORMATDESCRIPTOR();
        pixelFormat.nSize = SizeOf<PIXELFORMATDESCRIPTOR>();
        pixelFormat.nVersion = 1;
        pixelFormat.dwFlags = PFD_DRAW_TO_WINDOW | PFD_SUPPORT_OPENGL | PFD_DOUBLEBUFFER;
        pixelFormat.iPixelType = PFD_TYPE_RGBA;
        pixelFormat.cColorBits = 32;
        pixelFormat.cDepthBits = 32;
        pixelFormat.cStencilBits = 8;
        pixelFormat.iLayerType = PFD_MAIN_PLANE;
        return pixelFormat;
    }

    public static void DumpPixelFormat(nint deviceContext, int format)
    {
        PIXELFORMATDESCRIPTOR pixelFormat = new PIXELFORMATDESCRIPTOR();
        DescribePixelFormat(deviceContext, format, SizeOf<PIXELFORMATDESCRIPTOR>(), ref pixelFormat);
        Console.WriteLine($"{format} @ {deviceContext}");
        Console.WriteLine($"----------------------------------");
        Console.WriteLine($"Flags: {pixelFormat.dwFlags}");
        Console.WriteLine($"Pixel type: {pixelFormat.iPixelType}");
        Console.WriteLine($"Color buffer bits: {pixelFormat.cColorBits}");
        Console.WriteLine($"Depth buffer bits: {pixelFormat.cDepthBits}");
        Console.WriteLine($"Stencil buffer bits: {pixelFormat.cStencilBits}");
        Console.WriteLine($"----------------------------------");
    }

    private delegate nint wglCreateContextAttribsARB(nint hdc, nint hshareContext, int[] attribList);

    private nint CreateGLContext()
    {
        nint context = wglCreateContext(deviceContext);

        if (context == NULLPTR)
            throw new GLException("wglCreateContext");

        if (!wglMakeCurrent(deviceContext, context))
            throw new GLException("wglMakeCurrent");

        return context;
    }

    public void SetupGLContext(W32NativeAPILoader lookup)
    {
        deviceContext = GetDC(Handle);
        PIXELFORMATDESCRIPTOR pixelFormat = BuildPixelFormat();

        int format = ChoosePixelFormat(deviceContext, ref pixelFormat);
        if (format == 0)
            throw new GLException("ChoosePixelFormat");

        DumpPixelFormat(deviceContext, format);
        if (!SetPixelFormat(deviceContext, format, ref pixelFormat))
            throw new GLException("SetPixelFormat");

        nint tempContext = CreateGLContext();
        wglCreateContextAttribsARB createContextARB = lookup.LoadDelegateGL<wglCreateContextAttribsARB>("wglCreateContextAttribsARB");
        wglDeleteContext(tempContext);

        if (createContextARB == null)
        {
            Console.Error.WriteLine("Couldn't find wglCreateContextAttribsARB");
            glContext = CreateGLContext();
            return;
        }

        glContext = createContextARB(deviceContext, NULLPTR, new int[]
        {
            WGL_CONTEXT_MAJOR_VERSION_ARB, 1,
            WGL_CONTEXT_MINOR_VERSION_ARB, 1,
            0x00 // End of attributes
        });
        if (glContext == NULLPTR)
            throw new GLException("wglCreateContextAttribsARB");

        if (!wglMakeCurrent(deviceContext, glContext))
            throw new GLException("wglMakeCurrent");
    }
    #endregion

    public void Center()
    {
        RECT rect = new();
        GetWindowRect(Handle, ref rect);
        int sw = GetSystemMetrics(W32ConstSM.SM_CXSCREEN);
        int sh = GetSystemMetrics(W32ConstSM.SM_CYSCREEN);
        int w = rect.right - rect.left;
        int h = rect.bottom - rect.top;
        int x = sw / 2 - w / 2;
        int y = sh / 2 - h / 2;
        SetWindowPos(Handle, NULLPTR, x, y, w, h, SWP_SHOWWINDOW | SWP_NOZORDER | SWP_NOSIZE);
    }

    public void Poll()
    {
        MSG msg = new();
        if (PeekMessageA(ref msg, NULLPTR, 0, 0, PM_REMOVE))
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
                    PAINTSTRUCT paintStruct = new PAINTSTRUCT();
                    BeginPaint(hWnd, ref paintStruct);
                    EndPaint(hWnd, ref paintStruct);
                    break;
                }

            case WM_CLOSE:
                ShouldClose = true;
                break;

            case WM_KEYDOWN:
                {
                    short vk = (short)(int)wParam;
                    byte sc = (byte)(((int)lParam >> 16) & 0xFF);
                    bool repeat = ((int)lParam & (1 << 30)) > 0;
                    PutKBEvent(true, vk, sc, repeat);
                    break;
                }

            case WM_KEYUP:
                {
                    short vk = (short)(int)wParam;
                    byte sc = (byte)(((int)lParam >> 16) & 0xFF);
                    bool repeat = ((int)lParam & (1 << 30)) > 0;
                    PutKBEvent(false, vk, sc, repeat);
                    break;
                }

            case WM_SETCURSOR:
                if (CursorHidden)
                {
                    SetCursor(NULLPTR);
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
                {
                    ScrollWheel = (short)(((int)wParam >> 16) & 0xFFFF);
                    break;
                }

            default:
                return DefWindowProcA(hWnd, uMsg, wParam, lParam);
        }

        return NULLPTR;
    }

    public void Dispose()
    {
        KeyboardEvents.Clear();

        wglDeleteContext(glContext);
        ReleaseDC(Handle, deviceContext);
        DestroyWindow(Handle);
        // TODO: Call this somewhere
        // Right now it fucks up msg boxes so keep it disabled for now
        //PostQuitMessage(0);

        glContext = NULLPTR;
        deviceContext = NULLPTR;
        Handle = NULLPTR;
    }
}
