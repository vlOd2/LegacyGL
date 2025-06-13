// Copyright (c) vlOd
// Licensed under the GNU Lesser General Public License, version 3.0

using LegacyGL.Internal.Win32Impl.Native.Structs;
using System.Runtime.InteropServices;

namespace LegacyGL.Internal.Win32Impl.Native;

internal static class W32Painting
{
    [DllImport("user32.dll")]
    public static extern nint BeginPaint(nint hWnd, ref PAINTSTRUCT lpPaint);

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool EndPaint(nint hWnd, ref PAINTSTRUCT lpPaint);

    [DllImport("gdi32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool SwapBuffers(nint hdc);
}
