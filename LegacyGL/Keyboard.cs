// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

using LegacyGL.Internal;
using System;

namespace LegacyGL
{
    public static class Keyboard
    {
        private static IKeyboard instance;
        public static bool AllowRepeatEvents
        {
            get => GetPropSafe(instance.AllowRepeatEvents);
            set => EnsureLoaded(() => instance.AllowRepeatEvents = value);
        }

        internal static void Init(IKeyboard instance)
        {
            Dispose();
            Keyboard.instance = instance;
        }

        private static void EnsureLoaded(Action after = null)
        {
            if (instance == null)
                throw new GLException("Context not loaded");
            after?.Invoke();
        }

        private static T GetPropSafe<T>(T value)
        {
            if (instance == null)
                throw new GLException("Context not loaded");
            return value;
        }

        internal static void Poll()
        {
            EnsureLoaded();
            instance.Poll();
        }

        public static bool Next(out InputEvent @event)
        {
            EnsureLoaded();
            return instance.Next(out @event);
        }

        public static bool GetKeyState(int vk)
        {
            EnsureLoaded();
            return instance.GetKeyState(vk);
        }

        internal static void Dispose()
        {
            instance?.Dispose();
            instance = null;
        }
    }
}
