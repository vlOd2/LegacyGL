// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

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

    public static implicit operator Rectangle(RECT rect) => Rectangle.FromLTRB(rect.left, rect.top, rect.right, rect.bottom);
}
