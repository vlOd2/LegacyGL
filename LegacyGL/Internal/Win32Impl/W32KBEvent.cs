// Copyright (c) vlOd
// Licensed under the GNU Lesser General Public License, version 3.0

namespace LegacyGL.Internal.Win32Impl;

internal struct W32KBEvent
{
    public bool State;
    public short VK;
    public byte SC;
    public bool Repeat;
}
