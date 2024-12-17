// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

using System.Drawing;
using XLibSharp;
using ZeroCraft.LegacyGL.Internal.X11Impl;

namespace LegacyGL.Internal.X11Impl
{
    internal class X11LGL : ILGL
    {
        internal X11Viewport viewport;
        private X11GLLookup glLookup;
        private GLAPILoader apiLoader;
        #region Properties
        public int VWidth
        {
            get => viewport.Size.Width;
            set => viewport.Size = new Size(value, VHeight);
        }
        public int VHeight
        {
            get => viewport.Size.Height;
            set => viewport.Size = new Size(VWidth, value);
        }
        public string VTitle { get; set; }
        public nint VIcon { get; set; }
        public bool VResizable { get; set; }
        public bool ShouldClose => viewport.ShouldClose;
        public string ClipboardContent { get; set; }
        #endregion
        
        public void Init() 
        {
            try
            {
                glLookup = new X11GLLookup();
                apiLoader = new GLAPILoader(glLookup);
                viewport = new X11Viewport();
                apiLoader.Load();
            }
            catch (Exception e)
            {
                Dispose();
                throw;
            }
        }

        public IKeyboard GetKeyboard() 
        {
            X11Keyboard keyboard = new X11Keyboard();
            return keyboard;
        }

        public IMouse GetMouse() 
        {
            X11Mouse mouse = new X11Mouse();
            return mouse;
        }

        public void Center() => viewport.Center();

        public void Flush() => viewport.Swap();

        public void Poll() => viewport.Poll();

        public void Dispose()
        {
            apiLoader?.Unload();
            viewport?.Dispose();
            glLookup = null;
            viewport = null;
        }
    }
}