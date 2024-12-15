// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

namespace LegacyGL.Internal.Win32Impl.Native.Const
{
    internal static class W32ConstWS
    {
        public const int WS_EX_OVERLAPPEDWINDOW = WS_EX_WINDOWEDGE | WS_EX_CLIENTEDGE;
        public const int WS_EX_NOINHERITLAYOUT = 1048576;
        public const int WS_EX_RIGHTSCROLLBAR = 0;
        public const int WS_EX_NOPARENTNOTIFY = 4;
        public const int WS_OVERLAPPEDWINDOW = WS_OVERLAPPED | WS_CAPTION |
            WS_SYSMENU | WS_THICKFRAME | WS_MINIMIZEBOX | WS_MAXIMIZEBOX;
        public const int WS_EX_PALETTEWINDOW = WS_EX_WINDOWEDGE | WS_EX_TOOLWINDOW | WS_EX_TOPMOST;
        public const int WS_EX_LEFTSCROLLBAR = 16384;
        public const int WS_EX_DLGMODALFRAME = 1;
        public const int WS_EX_CONTROLPARENT = 65536;
        public const int WS_EX_TRANSPARENT = 32;
        public const int WS_EX_CONTEXTHELP = 1024;
        public const int WS_EX_ACCEPTFILES = 16;
        public const int WS_EX_WINDOWEDGE = 256;
        public const int WS_EX_TOOLWINDOW = 128;
        public const int WS_EX_STATICEDGE = 131072;
        public const int WS_EX_RTLREADING = 8192;
        public const int WS_EX_NOACTIVATE = 134217728;
        public const int WS_EX_LTRREADING = 0;
        public const int WS_EX_COMPOSITED = 33554432;
        public const int WS_EX_CLIENTEDGE = 512;
        public const int WS_ACTIVECAPTION = 1;
        public const int WS_EX_LAYOUTRTL = 4194304;
        public const int WS_EX_APPWINDOW = 262144;
        public const int WS_CLIPSIBLINGS = 67108864;
        public const int WS_CLIPCHILDREN = 33554432;
        public const int WS_TILEDWINDOW = WS_OVERLAPPEDWINDOW;
        public const int WS_POPUPWINDOW = WS_POPUP | WS_BORDER | WS_SYSMENU;
        public const int WS_MINIMIZEBOX = 131072;
        public const int WS_MAXIMIZEBOX = 65536;
        public const int WS_EX_MDICHILD = 64;
        public const int WS_CHILDWINDOW = WS_CHILD;
        public const int WS_THICKFRAME = 262144;
        public const int WS_OVERLAPPED = 0;
        public const int WS_EX_TOPMOST = 8;
        public const int WS_EX_LAYERED = 524288;
        public const int WS_MINIMIZE = 536870912;
        public const int WS_MAXIMIZE = 16777216;
        public const int WS_EX_RIGHT = 4096;
        public const int WS_DLGFRAME = 4194304;
        public const int WS_DISABLED = 134217728;
        public const int WS_VSCROLL = 2097152;
        public const int WS_VISIBLE = 268435456;
        public const int WS_TABSTOP = 65536;
        public const int WS_SYSMENU = 524288;
        public const int WS_SIZEBOX = WS_THICKFRAME;
        public const int WS_HSCROLL = 1048576;
        public const int WS_EX_LEFT = 0;
        public const int WS_CAPTION = 12582912;
        public const int WS_ICONIC = WS_MINIMIZE;
        public const int WS_BORDER = 8388608;
        public const int WS_TILED = WS_OVERLAPPED;
        public const int WS_POPUP = -2147483648;
        public const int WS_GROUP = 131072;
        public const int WS_CHILD = 1073741824;
    }
}
