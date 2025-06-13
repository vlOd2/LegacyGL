// Copyright (c) vlOd
// Licensed under the GNU Lesser General Public License, version 3.0

using System.Drawing;
using System.Runtime.InteropServices;

namespace LegacyGL.Internal.Win32Impl.Native.Structs;

[StructLayout(LayoutKind.Sequential)]
internal struct RECT
{
    public int left;
    public int top;
    public int right;
    public int bottom;

    public RECT(int l, int t, int r, int b)
    {
        left = l;
        top = t;
        right = r;
        bottom = b;
    }

    public static implicit operator Rectangle(RECT rect) => Rectangle.FromLTRB(rect.left, rect.top, rect.right, rect.bottom);

    public static implicit operator RECT(Rectangle rect) => new(rect.Left, rect.Top, rect.Right, rect.Bottom);
}
