// Copyright (c) vlOd
// Licensed under the GNU Lesser General Public License, version 3.0

namespace LegacyGL.Internal.Abstract;

internal interface IKeyboard : IDisposable
{
    bool AllowRepeatEvents { get; set; }
    void Poll();
    bool Next(out InputEvent e);
    bool GetKeyState(int vk);
    string GetFriendlyName(int vk);
}
