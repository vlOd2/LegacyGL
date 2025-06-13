// Copyright (c) vlOd
// Licensed under the GNU Lesser General Public License, version 3.0

using LegacyGL.Internal.Abstract;
using System.Drawing;

namespace LegacyGL;

/// <summary>
/// Manages mouse inputs<br/>
/// A viewport must be created in order to use these APIs
/// </summary>
public static class Mouse
{
    public const int LEFT = 0;
    public const int RIGHT = 1;
    public const int MIDDLE = 2;
    private static IMouse instance;
    #region Properties
    /// <summary>
    /// The position of the cursor, relative to the viewport
    /// </summary>
    public static Point Position
    {
        get => GetPropSafe(instance.Position);
        set => EnsureLoaded(() => instance.Position = value);
    }
    /// <summary>
    /// The amount the cursor has moved since last checked
    /// </summary>
    public static Point Delta => GetPropSafe(instance.Delta);
    /// <summary>
    /// Whether the cursor is captured to the viewport
    /// </summary>
    public static bool Captured
    {
        get => GetPropSafe(instance.Captured);
        set => EnsureLoaded(() => instance.Captured = value);
    }
    /// <summary>
    /// The state of the left button
    /// </summary>
    public static bool LeftButton => GetPropSafe(instance.LeftButton);
    /// <summary>
    /// The state of the right button
    /// </summary>
    public static bool RightButton => GetPropSafe(instance.RightButton);
    /// <summary>
    /// The state of the middle button
    /// </summary>
    public static bool MiddleButton => GetPropSafe(instance.MiddleButton);
    /// <summary>
    /// The state of the scroll wheel since last checked
    /// </summary>
    public static int ScrollWheel => GetPropSafe(instance.ScrollWheel);
    #endregion

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

    /// <summary>
    /// Gets the next available mouse event
    /// </summary>
    /// <param name="e">the mouse event</param>
    /// <returns>true if there was an event, false if not</returns>
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
