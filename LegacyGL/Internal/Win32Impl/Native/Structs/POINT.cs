// Copyright (c) vlOd
// Licensed under the GNU Lesser General Public License, version 3.0

using System.Drawing;
using System.Runtime.InteropServices;

namespace LegacyGL.Internal.Win32Impl.Native.Structs;

[StructLayout(LayoutKind.Sequential)]
internal struct POINT
{
    public int x;
    public int y;

    public POINT(int x, int y) 
    {
        this.x = x;
        this.y = y;
    }

    public static implicit operator Point(POINT point) => new(point.x, point.y);

    public static implicit operator POINT(Point point) => new(point.X, point.Y);
}