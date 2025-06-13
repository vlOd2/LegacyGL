// Copyright (c) vlOd
// Licensed under the GNU Lesser General Public License, version 3.0

using System.Drawing;

namespace LegacyGL.Internal.Abstract;

internal interface IMouse : IDisposable
{
    Point Position { get; set; }
    Point Delta { get; }
    bool Captured { get; set; }
    bool LeftButton { get; }
    bool MiddleButton { get; }
    bool RightButton { get; }
    int ScrollWheel { get; }
    void Poll();
    bool Next(out InputEvent e);
}
