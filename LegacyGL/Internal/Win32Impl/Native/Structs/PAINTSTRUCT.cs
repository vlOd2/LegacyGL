// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

using System;
using System.Runtime.InteropServices;

namespace LegacyGL.Internal.Win32Impl.Native.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct PAINTSTRUCT
    {
        public nint hdc;
        [MarshalAs(UnmanagedType.Bool)]
        public bool fErase;
        public RECT rcPaint;
        [MarshalAs(UnmanagedType.Bool)]
        public bool fRestore;
        [MarshalAs(UnmanagedType.Bool)]
        public bool fIncUpdate;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
        public byte[] rgbReserved;
    }
}
