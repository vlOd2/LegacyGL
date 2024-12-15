// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

using System.Collections.Generic;
using static LegacyGL.Internal.Win32Impl.Native.W32Input;

namespace LegacyGL.Internal.Win32Impl
{
    internal class W32Keyboard : IKeyboard
    {
        private const int REPEAT_INTERVAL = 125; // value, ... fresh from my ass
        private W32Viewport viewport;
        private bool[] keyStates = new bool[256];
        private Queue<InputEvent> events = new Queue<InputEvent>();
        public bool AllowRepeatEvents { get; set; }

        public void Init(W32Viewport viewport)
        {
            this.viewport = viewport;
        }

        private void EnqueueKeyEvent(int vk, char c, bool state, bool repeated)
        {
            InputEvent inputEvent = new InputEvent();
            inputEvent.VK = vk;
            inputEvent.Char = c;
            inputEvent.State = state;
            inputEvent.Repeated = repeated;
            inputEvent.Millis = Utils.UnixMillis;
            inputEvent.Filled = true;
            events.Enqueue(inputEvent);
        }

        private char TranslateVK(short vk, byte sc, byte[] states)
        {
            ushort result;
            if (ToAscii(vk, sc, states, out result, 0) == 0)
                return '\0';
            return (char)(result & 0xFF);
        }

        public void Poll()
        {
            byte[] kbState = new byte[256];
            GetKeyboardState(kbState);

            for (int i = 0; i < kbState.Length; i++)
                keyStates[i] = (kbState[i] & 0x80) != 0;

            lock (viewport.KeyboardEvents.SyncRoot)
            {
                while (viewport.KeyboardEvents.Count > 0)
                {
                    W32KBEvent kbEvent = viewport.KeyboardEvents.Dequeue();
                    bool state = kbEvent.State;
                    short vk = kbEvent.VK;
                    byte sc = kbEvent.SC;
                    bool repeat = kbEvent.Repeat;

                    if (state && repeat && !AllowRepeatEvents)
                        continue;

                    char c = TranslateVK(vk, sc, kbState);
                    EnqueueKeyEvent(vk, c, state, repeat);

                    //Console.WriteLine($"{(state ? "Pressed" : "Released")} {c} (0x{vk:X2}) {repeat}");
                }
            }
        }

        public bool Next(out InputEvent @event)
        {
            if (events.Count == 0)
            {
                @event = new InputEvent();
                return false;
            }
            @event = events.Dequeue();
            return true;
        }

        public bool GetKeyState(int vk) => keyStates[vk];

        public void Dispose()
        {
            viewport = null;
        }
    }
}
