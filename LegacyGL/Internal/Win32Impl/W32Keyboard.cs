// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

using LegacyGL.Internal.Abstract;
using static LegacyGL.Internal.Win32Impl.Native.W32Input;

namespace LegacyGL.Internal.Win32Impl;

internal class W32Keyboard : IKeyboard
{
    private W32Viewport viewport;
    private bool[] keyStates = new bool[256];
    private readonly Queue<InputEvent> events = [];
    public bool AllowRepeatEvents { get; set; }

    public void Init(W32Viewport viewport)
    {
        this.viewport = viewport;
    }

    private void EnqueueKeyEvent(int vk, char c, bool state, bool repeated)
    {
        events.Enqueue(new()
        {
            VK = vk,
            Char = c,
            State = state,
            Repeated = repeated,
            Millis = Utils.UnixMillis,
            Filled = true
        });
    }

    private char TranslateVK(short vk, byte sc, byte[] states)
    {
        if (ToAscii(vk, sc, states, out ushort result, 0) == 0)
            return '\0';
        return (char)(result & 0xFF);
    }

    public void Poll()
    {
        byte[] kbState = new byte[256];
        GetKeyboardState(kbState);

        for (int i = 0; i < kbState.Length; i++)
            keyStates[i] = (kbState[i] & 0x80) != 0;

        while (viewport.KeyboardEvents.TryDequeue(out W32KBEvent kbEvent))
        {
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

    public bool Next(out InputEvent e)
    {
        if (events.Count == 0)
        {
            e = new InputEvent();
            return false;
        }
        e = events.Dequeue();
        return true;
    }

    public bool GetKeyState(int vk) => keyStates[vk];

    public void Dispose()
    {
        viewport = null;
    }
}
