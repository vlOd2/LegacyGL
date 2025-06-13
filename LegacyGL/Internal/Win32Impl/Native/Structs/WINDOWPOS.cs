// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

using System.Runtime.InteropServices;

namespace LegacyGL.Internal.Win32Impl.Native.Structs;

[StructLayout(LayoutKind.Sequential)]
internal struct WINDOWPOS
{
    public nint hwnd;
    public nint hwndInsertAfter;
    public int x;
    public int y;
    public int w;
    public int h;
    public uint flags;
}
