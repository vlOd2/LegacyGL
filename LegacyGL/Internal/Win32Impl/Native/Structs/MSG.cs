// Copyright (c) vlOd
// Licensed under the GNU Lesser General Public License, version 3.0

using System.Runtime.InteropServices;

namespace LegacyGL.Internal.Win32Impl.Native.Structs;

[StructLayout(LayoutKind.Sequential)]
internal struct MSG
{
    public nint hwnd;
    public uint message;
    public nint wParam;
    public nint lParam;
    public int time;
    public POINT pt;
    public int lPrivate;
}
