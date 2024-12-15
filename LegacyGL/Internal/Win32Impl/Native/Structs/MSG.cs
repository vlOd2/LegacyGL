// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace LegacyGL.Internal.Win32Impl.Native.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct MSG
    {
        public IntPtr hwnd;
        public int message;
        public int wParam;
        public int lParam;
        public int time;
        public Point pt;
    }
}
