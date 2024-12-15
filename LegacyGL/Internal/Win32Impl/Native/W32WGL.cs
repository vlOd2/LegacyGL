// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

using System;
using System.Runtime.InteropServices;

namespace LegacyGL.Internal.Win32Impl.Native
{
    internal static class W32WGL
    {
        [DllImport("opengl32.dll", SetLastError = true)]
        public static extern nint wglCreateContext(nint hdc);

        [DllImport("opengl32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool wglMakeCurrent(nint hdc, nint hglrc);

        [DllImport("opengl32.dll")]
        public static extern nint wglGetProcAddress(
            [In()][MarshalAs(UnmanagedType.LPStr)] string ext);

        [DllImport("opengl32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool wglDeleteContext(nint hglrc);
    }
}
