// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

namespace LegacyGL.Internal.Win32Impl.Native.Const;

internal static class W32ConstQS
{
    public const int QS_ALLPOSTMESSAGE = 256;
    public const int QS_SENDMESSAGE = 64;
    public const int QS_POSTMESSAGE = 8;
    public const int QS_MOUSEBUTTON = 4;
    public const int QS_MOUSEMOVE = 2;
    public const int QS_ALLEVENTS = QS_INPUT | QS_POSTMESSAGE | QS_TIMER | QS_PAINT | QS_HOTKEY;
    public const int QS_RAWINPUT = 1024;
    public const int QS_ALLINPUT = QS_INPUT | QS_POSTMESSAGE | QS_TIMER | QS_PAINT | QS_HOTKEY | QS_SENDMESSAGE;
    public const int QS_HOTKEY = 128;
    public const int QS_TIMER = 16;
    public const int QS_PAINT = 32;
    public const int QS_MOUSE = QS_MOUSEMOVE | QS_MOUSEBUTTON;
    public const int QS_INPUT = QS_MOUSE | QS_KEY | QS_RAWINPUT;
    public const int QS_KEY = 1;
}
