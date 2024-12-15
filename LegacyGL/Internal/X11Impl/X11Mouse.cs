using System.Drawing;
using LegacyGL;
using LegacyGL.Internal;

namespace ZeroCraft.LegacyGL.Internal.X11Impl
{
    internal class X11Mouse : IMouse
    {
        public Point Position { get; set; }
        public Point Delta { get; }
        public bool Captured { get; set; }
        public bool LeftButton { get; }
        public bool MiddleButton { get; }
        public bool RightButton { get; }
        public float ScrollWheel { get; }

        public void Poll()
        {

        }

        public bool Next(out InputEvent @event) 
        {
            @event = new InputEvent();
            return false;
        }

        public void Dispose()
        {
        }
    }
}