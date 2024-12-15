// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

using System;
using System.Runtime.InteropServices;

namespace LegacyGL.Internal.Win32Impl.Native
{
    internal static class W32Clipboard
    {
        public const int CF_TEXT = 1;

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool OpenClipboard(nint hWndNewOwner);

        [DllImport("user32.dll")]
        public static extern nint GetClipboardData(uint uFormat);

        [DllImport("user32.dll")]
        public static extern nint SetClipboardData(int uFormat, nint hMem);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseClipboard();
    }
}
