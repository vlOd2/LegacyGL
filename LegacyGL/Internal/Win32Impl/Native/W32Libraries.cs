// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

using System;
using System.Runtime.InteropServices;

namespace LegacyGL.Internal.Win32Impl.Native
{
    internal static class W32Libraries
    {
        [DllImport("kernel32.dll")]
        public static extern nint LoadLibraryA(
            [In()][MarshalAs(UnmanagedType.LPStr)] string lpLibFileName);

        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FreeLibrary(nint hLibModule);

        [DllImport("kernel32.dll")]
        public static extern nint GetModuleHandle(string lpModuleName);

        [DllImport("kernel32.dll")]
        public static extern nint GetProcAddress(nint hModule, string lpProcName);
    }
}
