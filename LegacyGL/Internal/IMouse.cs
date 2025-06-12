// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

using System;
using System.Drawing;

namespace LegacyGL.Internal;

internal interface IMouse : IDisposable
{
    Point Position { get; set; }
    Point Delta { get; }
    bool Captured { get; set; }
    bool LeftButton { get; }
    bool MiddleButton { get; }
    bool RightButton { get; }
    float ScrollWheel { get; }
    void Poll();
    bool Next(out InputEvent e);
}
