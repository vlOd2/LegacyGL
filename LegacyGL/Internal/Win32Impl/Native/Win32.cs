// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

using System;
using System.Runtime.InteropServices;

namespace LegacyGL.Internal.Win32Impl.Native
{
    internal static class Win32
    {
        public static readonly nint NULLPTR = nint.Zero;
        public const int CW_USEDEFAULT = unchecked((int)0x80000000);

        [DllImport("user32.dll")]
        public static extern int GetSystemMetrics(int nIndex);

        public static short SizeOf<T>(T? obj = null) where T : struct
        {
            int size = obj != null ? Marshal.SizeOf(obj) : Marshal.SizeOf(typeof(T));
            return (short)size;
        }

        public static short GET_X_LPARAM(int lparam)
        {
            return (short)(lparam & 0xFFFF);
        }

        public static short GET_Y_LPARAM(int lparam)
        {
            return (short)((lparam >> 16) & 0xFFFF);
        }
    }
}
