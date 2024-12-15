using System.Drawing;
using ZeroCraft.LegacyGL.Internal.X11Impl;

namespace LegacyGL.Internal.X11Impl
{
    internal class X11LGL : ILGL
    {
        private const string GL_LIBRARY = "libGL.so.1";

        public int VWidth { get; set; }
        public int VHeight { get; set; }
        public string VTitle { get; set; }
        public Icon VIcon { get; set; }
        public bool VResizable { get; set; }
        public bool ShouldClose { get; }
        public string ClipboardContent { get; set; }

        public void Init() 
        {
            
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

        public void Center() 
        {
            
        }

        public void Flush() 
        {

        }

        public void Poll() 
        {

        }

        public void Dispose()
        {
        }
    }
}