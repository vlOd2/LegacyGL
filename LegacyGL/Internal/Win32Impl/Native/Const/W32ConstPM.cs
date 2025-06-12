// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

using static LegacyGL.Internal.Win32Impl.Native.Const.W32ConstQS;

namespace LegacyGL.Internal.Win32Impl.Native.Const;

internal static class W32ConstPM
{
    public const int PM_QS_SENDMESSAGE = QS_SENDMESSAGE << 16;
    public const int PM_QS_POSTMESSAGE = (QS_POSTMESSAGE | (QS_HOTKEY | QS_TIMER)) << 16;
    public const int PM_QS_PAINT = QS_PAINT << 16;
    public const int PM_QS_INPUT = QS_INPUT << 16;
    public const int PM_NOREMOVE = 0;
    public const int PM_NOYIELD = 2;
    public const int PM_REMOVE = 1;
}
