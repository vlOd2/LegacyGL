// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

using LegacyGL.Internal.Abstract;
using LegacyGL.Internal.Win32Impl.Native.Structs;
using System.Collections.Generic;
using System.Drawing;
using static LegacyGL.Internal.Win32Impl.Native.W32Input;
using static LegacyGL.Internal.Win32Impl.Native.W32Windowing;

namespace LegacyGL.Internal.Win32Impl;

internal class W32Mouse : IMouse
{
    private const int BTN_LEFT = 0;
    private const int BTN_RIGHT = 1;
    private const int BTN_MIDDLE = 2;
    private W32Viewport viewport;
    private Point delta;
    private Point lastPos = new Point(-9999, -9999);
    private readonly bool[] buttonStates = new bool[3];
    private readonly Queue<InputEvent> events = [];
    public bool Captured { get => viewport.CursorHidden; set => viewport.CursorHidden = value; }
    public Point Position
    {
        get => lastPos;
        set => SetCursorPos(value.X, value.Y);
    }
    public Point Delta
    {
        get
        {
            Point delta = this.delta;
            this.delta = Point.Empty;
            return delta;
        }
    }
    public bool LeftButton => buttonStates[BTN_LEFT];
    public bool RightButton => buttonStates[BTN_RIGHT];
    public bool MiddleButton => buttonStates[BTN_MIDDLE];
    public float ScrollWheel
    {
        get
        {
            float wheel = viewport.ScrollWheel;
            viewport.ScrollWheel = 0;
            return wheel;
        }
    }

    public void Init(W32Viewport viewport)
    {
        this.viewport = viewport;
    }

    private void PollPosition(POINT pos)
    {
        if (!Captured)
            ScreenToClient(viewport.Handle, ref pos);

        if (pos == lastPos)
            return;

        int mx = pos.x;
        int my = pos.y;
        int dx = mx - lastPos.X;
        int dy = my - lastPos.Y;
        delta.X += dx;
        delta.Y -= dy;

        if (Captured)
        {
            int cx = viewport.Position.X + viewport.Size.Width / 2;
            int cy = viewport.Position.Y + viewport.Size.Height / 2;
            lastPos = new Point(cx, cy);
            SetCursorPos(cx, cy);
        }
        else
            lastPos = new Point(mx, my);
    }

    private void EnqueueButtonEvent(int vk, bool state)
    {
        InputEvent inputEvent = new InputEvent();
        inputEvent.VK = vk;
        inputEvent.State = state;
        inputEvent.Millis = Utils.UnixMillis;
        inputEvent.Filled = true;
        events.Enqueue(inputEvent);
    }

    private void PollButtons()
    {
        bool lmb = Keyboard.GetKeyState(VKs.VK_LBUTTON);
        bool rmb = Keyboard.GetKeyState(VKs.VK_RBUTTON);
        bool mmb = Keyboard.GetKeyState(VKs.VK_MBUTTON);

        if (!buttonStates[BTN_LEFT] && lmb)
            EnqueueButtonEvent(BTN_LEFT, true);
        else if (buttonStates[BTN_LEFT] && !lmb)
            EnqueueButtonEvent(BTN_LEFT, false);

        if (!buttonStates[BTN_RIGHT] && rmb)
            EnqueueButtonEvent(BTN_RIGHT, true);
        else if (buttonStates[BTN_RIGHT] && !rmb)
            EnqueueButtonEvent(BTN_RIGHT, false);

        if (!buttonStates[BTN_MIDDLE] && mmb)
            EnqueueButtonEvent(BTN_MIDDLE, true);
        else if (buttonStates[BTN_MIDDLE] && !mmb)
            EnqueueButtonEvent(BTN_MIDDLE, false);

        buttonStates[BTN_LEFT] = lmb;
        buttonStates[BTN_RIGHT] = rmb;
        buttonStates[BTN_MIDDLE] = mmb;
    }

    public void Poll()
    {
        if (!viewport.Focused)
            return;

        RECT wndRect = new();
        GetWindowRect(viewport.Handle, ref wndRect);

        POINT curPos = new();
        GetCursorPos(ref curPos);

        if (curPos.x < wndRect.left || curPos.y < wndRect.top ||
            curPos.x > wndRect.right || curPos.y > wndRect.bottom)
            return;

        PollPosition(curPos);
        PollButtons();
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

    public void Dispose()
    {
        viewport = null;
    }
}
