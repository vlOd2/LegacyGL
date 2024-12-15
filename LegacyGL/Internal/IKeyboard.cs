// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

using System;

namespace LegacyGL.Internal
{
    internal interface IKeyboard : IDisposable
    {
        bool AllowRepeatEvents { get; set; }
        void Poll();
        bool Next(out InputEvent @event);
        bool GetKeyState(int vk);
    }
}
