// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

using LegacyGL.Internal;
using System;
using System.Drawing;

namespace LegacyGL;

public static class Mouse
{
    public const int LEFT = 0;
    public const int RIGHT = 1;
    public const int MIDDLE = 2;
    private static IMouse instance;
    public static Point Position
    {
        get => GetPropSafe(instance.Position);
        set => EnsureLoaded(() => instance.Position = value);
    }
    public static Point Delta => GetPropSafe(instance.Delta);
    public static bool Captured
    {
        get => GetPropSafe(instance.Captured);
        set => EnsureLoaded(() => instance.Captured = value);
    }
    public static bool LeftButton => GetPropSafe(instance.LeftButton);
    public static bool RightButton => GetPropSafe(instance.RightButton);
    public static bool MiddleButton => GetPropSafe(instance.MiddleButton);
    public static float ScrollWheel => GetPropSafe(instance.ScrollWheel);

    internal static void Init(IMouse instance)
    {
        Dispose();
        Mouse.instance = instance;
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

    internal static void Dispose()
    {
        instance?.Dispose();
        instance = null;
    }
}
