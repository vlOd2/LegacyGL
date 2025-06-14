﻿// Copyright (c) vlOd
// Licensed under the GNU Lesser General Public License, version 3.0

using LegacyGL.Internal.Abstract;
using LegacyGL.Internal.Win32Impl.Native;
using System.Drawing;
using System.Runtime.InteropServices;
using static LegacyGL.Internal.Win32Impl.Native.W32Clipboard;

namespace LegacyGL.Internal.Win32Impl;

internal unsafe class W32LGL : ILGL
{
    private const string GL_LIBRARY = "OpenGL32.dll";
    private const string AL_LIBRARY = "OpenAL32.dll";
    private nint glLib;
    private nint alLib;
    internal W32Viewport viewport;
    internal W32Keyboard keyboard;
    internal W32Mouse mouse;
    internal W32NativeAPILoader apiLoader;
    #region Properties
    public Size Size
    {
        get => viewport.ClientSize;
        set => viewport.ClientSize = value;
    }
    public string Title { get => viewport.Title; set => viewport.Title = value; }
    public nint Icon { get => viewport.Icon; set => viewport.Icon = value; }
    public bool Resizable { get => viewport.Resizable; set => viewport.Resizable = value; }
    public bool ShouldClose => viewport.ShouldClose;
    public bool Focused => viewport.Focused;
    public string ClipboardContent
    {
        get
        {
            if (!OpenClipboard(0))
                return "";
            nint handle = GetClipboardData(CF_TEXT);
            string data = Marshal.PtrToStringAnsi(handle);
            CloseClipboard();
            return data ?? "";
        }
        set
        {
            if (!OpenClipboard(0))
                return;
            nint handle = Marshal.StringToHGlobalAnsi(value);
            SetClipboardData(CF_TEXT, handle);
            Marshal.FreeHGlobal(handle);
            CloseClipboard();
        }
    }
    public IKeyboard Keyboard => keyboard;
    public IMouse Mouse => mouse;
    public INativeAPILoader APILoader => apiLoader;
    #endregion

    private delegate bool wglSwapIntervalEXT(int interval);

    public void Init(ref ContextRequest ctxReq)
    {
        try
        {
            glLib = W32Libraries.LoadLibraryA(GL_LIBRARY);
            if (glLib == 0)
                throw new GLException($"Could not load OpenGL: LoadLibraryA failed ({GL_LIBRARY})");
            apiLoader = new W32NativeAPILoader(glLib);

            viewport = new W32Viewport();
            if (!viewport.CreateWindow())
                throw new GLException("Could not initialize display");
            if (!viewport.CreateContext(ref ctxReq, apiLoader))
                throw new GLException("Pixel format not accelerated");

            keyboard = new W32Keyboard();
            keyboard.Init(viewport);
            mouse = new W32Mouse();
            mouse.Init(viewport);
            InitAL();

            wglSwapIntervalEXT wglSwapInterval = apiLoader.LoadDelegateGL<wglSwapIntervalEXT>("wglSwapIntervalEXT");
            if (wglSwapInterval == null)
            {
                LGL.ErrorLogHandler("wglSwapIntervalEXT not found: swap interval control unavailable");
                return;
            }
            wglSwapInterval(0);
        }
        catch
        {
            Dispose();
            throw;
        }
    }

    private void InitAL()
    {
        alLib = W32Libraries.LoadLibraryA(AL_LIBRARY);
        if (alLib == 0)
        {
            LGL.ErrorLogHandler($"Could not load OpenAL: LoadLibraryA failed ({AL_LIBRARY})");
            return;
        }
        apiLoader.ALLib = alLib;
        try
        {
            ALLoader.Load(apiLoader);
        }
        catch (Exception ex)
        {
            LGL.ErrorLogHandler($"Could not load OpenAL: {ex}");
            ALLoader.Unload();
        }
    }

    public void Center() => viewport.Center();

    public void Flush() => viewport.Swap();

    public void Poll() => viewport.Poll();

    public void Dispose()
    {
        viewport?.Dispose();

        try
        {
            if (glLib != 0)
                W32Libraries.FreeLibrary(glLib);
            if (alLib != 0)
                W32Libraries.FreeLibrary(alLib);
        }
        catch { }

        glLib = 0;
        alLib = 0;
        apiLoader = null;
        ALLoader.Unload();

        mouse = null;
        keyboard = null;
        viewport = null;
    }
}
