// Copyright (c) vlOd
// Licensed under the GNU Lesser General Public License, version 3.0

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace LegacyGL.Internal.Win32Impl.Native;

internal static class Win32
{
    public const int CW_USEDEFAULT = unchecked((int)0x80000000);

    [DllImport("user32.dll")]
    public static extern int GetSystemMetrics(int nIndex);

    public static short SizeOf<T>(T? obj = null) where T : struct => (short)(obj != null ? Marshal.SizeOf(obj) : Marshal.SizeOf(typeof(T)));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static short LOWORD(nint l) => (short)(((long)l) & 0xFFFF);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static short HIWORD(nint l) => (short)(((long)l >> 16) & 0xFFFF);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int GET_X_LPARAM(nint lp) => LOWORD(lp);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int GET_Y_LPARAM(nint lp) => HIWORD(lp);
}
