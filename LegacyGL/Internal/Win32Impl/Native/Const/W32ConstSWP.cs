// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

namespace LegacyGL.Internal.Win32Impl.Native.Const;

internal static class W32ConstSWP
{
    public const int SWP_NOSENDCHANGING = 1024;
    public const int SWP_ASYNCWINDOWPOS = 16384;
    public const int SWP_NOOWNERZORDER = 512;
    public const int SWP_NOREPOSITION = SWP_NOOWNERZORDER;
    public const int SWP_FRAMECHANGED = 32;
    public const int SWP_SHOWWINDOW = 64;
    public const int SWP_NOCOPYBITS = 256;
    public const int SWP_NOACTIVATE = 16;
    public const int SWP_HIDEWINDOW = 128;
    public const int SWP_DEFERERASE = 8192;
    public const int SWP_DRAWFRAME = SWP_FRAMECHANGED;
    public const int SWP_NOZORDER = 4;
    public const int SWP_NOREDRAW = 8;
    public const int SWP_NOSIZE = 1;
    public const int SWP_NOMOVE = 2;
}
