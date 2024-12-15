// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

using LegacyGL.Internal.Win32Impl.Native.Structs;
using System;
using System.Runtime.InteropServices;

namespace LegacyGL.Internal.Win32Impl.Native
{
    internal static class W32PixelFormat
    {
        [DllImport("user32.dll")]
        public static extern nint GetDC(nint hWnd);

        [DllImport("gdi32.dll", SetLastError = true)]
        public static extern int ChoosePixelFormat(nint hdc, ref PIXELFORMATDESCRIPTOR ppfd);

        [DllImport("gdi32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetPixelFormat(nint hdc, int format, ref PIXELFORMATDESCRIPTOR ppfd);

        [DllImport("gdi32.dll", SetLastError = true)]
        public static extern int DescribePixelFormat(nint hdc, int iPixelFormat, int nBytes, ref PIXELFORMATDESCRIPTOR ppfd);

        [DllImport("user32.dll")]
        public static extern int ReleaseDC(nint hWnd, nint hDC);
    }
}
