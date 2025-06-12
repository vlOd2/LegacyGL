// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

namespace LegacyGL.Internal.X11Impl;

internal class X11Keyboard : IKeyboard
{
    public bool AllowRepeatEvents { get; set; }

    public bool GetKeyState(int vk)
    {
        return false;
    }

    public bool Next(out InputEvent @event)
    {
        @event = new InputEvent();
        return false;
    }

    public void Poll()
    {
    }

    public void Dispose()
    {
    }
}