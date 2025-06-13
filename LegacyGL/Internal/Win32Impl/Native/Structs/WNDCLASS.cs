// Copyright (c) vlOd
// Licensed under the GNU Lesser General Public License, version 3.0

using System.Runtime.InteropServices;

namespace LegacyGL.Internal.Win32Impl.Native;

[UnmanagedFunctionPointer(CallingConvention.StdCall)]
internal delegate nint WNDPROC(nint hWnd, uint uMsg, nint wParam, nint lParam);

[StructLayout(LayoutKind.Sequential)]
internal struct WNDCLASS
{
    public uint style;
    public WNDPROC lpfnWndProc;
    public int cbClsExtra;
    public int cbWndExtra;
    public nint hInstance;
    public nint hIcon;
    public nint hCursor;
    public nint hbrBackground;
    [MarshalAs(UnmanagedType.LPStr)]
    public string lpszMenuName;
    [MarshalAs(UnmanagedType.LPStr)]
    public string lpszClassName;
}
