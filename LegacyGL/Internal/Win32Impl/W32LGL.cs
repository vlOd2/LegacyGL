// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

using LegacyGL.Internal.Abstract;
using LegacyGL.Internal.Win32Impl.Native;
using System.Drawing;
using System.Runtime.InteropServices;
using static LegacyGL.Internal.Win32Impl.Native.W32Clipboard;
using static LegacyGL.Internal.Win32Impl.Native.Win32;

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
    public int VWidth
    {
        get => viewport.ClientSize.Width;
        set => viewport.ClientSize = new Size(value, VHeight);
    }
    public int VHeight
    {
        get => viewport.ClientSize.Height;
        set => viewport.ClientSize = new Size(VWidth, value);
    }
    public string VTitle { get => viewport.Title; set => viewport.Title = value; }
    public nint VIcon { get => viewport.Icon; set => viewport.Icon = value; }
    public bool VResizable { get => viewport.Resizable; set => viewport.Resizable = value; }
    public bool ShouldClose => viewport.ShouldClose;
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
            apiLoader = new W32NativeAPILoader(glLib, alLib);

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

            // If this is NULL, V-sync isn't implemented??????
            apiLoader.LoadDelegateGL<wglSwapIntervalEXT>("wglSwapIntervalEXT")?.Invoke(0);
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
