// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

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
            if (!OpenClipboard(NULLPTR))
                return "";
            nint handle = GetClipboardData(CF_TEXT);
            string data = Marshal.PtrToStringAnsi(handle);
            CloseClipboard();
            return data ?? "";
        }
        set
        {
            if (!OpenClipboard(NULLPTR))
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

    public void Init()
    {
        try
        {
            glLib = W32Libraries.LoadLibraryA(GL_LIBRARY);
            alLib = W32Libraries.LoadLibraryA(AL_LIBRARY);

            apiLoader = new W32NativeAPILoader(glLib, alLib);
            viewport = new W32Viewport();
            keyboard = new W32Keyboard();
            mouse = new W32Mouse();

            viewport.SetupGLContext(apiLoader);
            keyboard.Init(viewport);
            mouse.Init(viewport);

            if (!viewport.HasGLContext)
                throw new GLException("Viewport has no GL context");

            // XXX: If this is NULL, V-sync isn't implemented?
            apiLoader.LoadDelegateGL<wglSwapIntervalEXT>("wglSwapIntervalEXT")?.Invoke(0);
        }
        catch
        {
            Dispose();
            throw;
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
            if (glLib != NULLPTR)
                W32Libraries.FreeLibrary(glLib);
            if (alLib != NULLPTR)
                W32Libraries.FreeLibrary(alLib);
        }
        catch { }

        glLib = NULLPTR;
        alLib = NULLPTR;
        apiLoader = null;

        mouse = null;
        keyboard = null;
        viewport = null;
    }
}
