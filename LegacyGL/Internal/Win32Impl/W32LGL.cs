// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

using LegacyGL.Internal.Win32Impl.Native;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using static LegacyGL.Internal.Win32Impl.Native.W32Clipboard;
using static LegacyGL.Internal.Win32Impl.Native.Win32;

namespace LegacyGL.Internal.Win32Impl
{
    internal class W32LGL : ILGL
    {
        private const string GL_LIBRARY = "OpenGL32.dll";
        private IntPtr glLib;
        private W32GLLookup glLookup;
        private GLAPILoader apiLoader;
        internal W32Viewport viewport;

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
        public Icon VIcon { get => viewport.Icon; set => viewport.Icon = value; }
        public bool VResizable { get => viewport.Resizable; set => viewport.Resizable = value; }
        public bool ShouldClose => viewport.ShouldClose;
        public string ClipboardContent
        {
            get
            {
                if (!OpenClipboard(NULLPTR))
                    return "";
                IntPtr handle = GetClipboardData(CF_TEXT);
                string data = Marshal.PtrToStringAnsi(handle);
                CloseClipboard();
                return data ?? "";
            }
            set
            {
                if (!OpenClipboard(NULLPTR))
                    return;
                IntPtr handle = Marshal.StringToHGlobalAnsi(value);
                SetClipboardData(CF_TEXT, handle);
                Marshal.FreeHGlobal(handle);
                CloseClipboard();
            }
        }
        #endregion

        private delegate bool wglSwapIntervalEXT(int interval);

        public void Init()
        {
            try
            {
                glLib = W32Libraries.LoadLibraryA(GL_LIBRARY);
                glLookup = new W32GLLookup(glLib);
                apiLoader = new GLAPILoader(glLookup);

                viewport = new W32Viewport();
                viewport.SetupGLContext(glLookup);

                if (!viewport.HasGLContext)
                    throw new GLException("Viewport has no GL context");
                apiLoader.Load();

                // XXX: If this is NULL, V-sync isn't implemented?
                glLookup.Lookup<wglSwapIntervalEXT>(true)?.Invoke(0);
            }
            catch
            {
                Dispose();
                throw;
            }
        }

        public IKeyboard GetKeyboard()
        {
            W32Keyboard keyboard = new W32Keyboard();
            keyboard.Init(viewport);
            return keyboard;
        }

        public IMouse GetMouse()
        {
            W32Mouse mouse = new W32Mouse();
            mouse.Init(viewport);
            return mouse;
        }

        public void Center() => viewport.Center();

        public void Flush() => viewport.Swap();

        public void Poll() => viewport.Poll();

        public void Dispose()
        {
            viewport?.Dispose();
            apiLoader?.Unload();

            try
            {
                if (glLib != NULLPTR)
                    W32Libraries.FreeLibrary(glLib);
            }
            catch { }

            glLib = NULLPTR;
            glLookup = null;
            viewport = null;
        }
    }
}
