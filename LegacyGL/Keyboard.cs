// Copyright (c) vlOd
// Licensed under the GNU Lesser General Public License, version 3.0

using LegacyGL.Internal.Abstract;

namespace LegacyGL;

/// <summary>
/// Manages keyboard inputs<br/>
/// A viewport must be created in order to use these APIs
/// </summary>
public static class Keyboard
{
    private static IKeyboard instance;
    /// <summary>
    /// Whether repeated keys are received
    /// </summary>
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

    /// <summary>
    /// Gets the next available keyboard event
    /// </summary>
    /// <param name="e">the keyboard event</param>
    /// <returns>true if there was an event, false if not</returns>
    public static bool Next(out InputEvent e)
    {
        EnsureLoaded();
        return instance.Next(out e);
    }

    /// <summary>
    /// Checks the state of the given key
    /// </summary>
    /// <param name="vk">the virtual key</param>
    /// <returns>true if the key is pressed, false if not</returns>
    public static bool GetKeyState(int vk)
    {
        EnsureLoaded();
        return instance.GetKeyState(vk);
    }

    /// <summary>
    /// Gets the friendly name of the given key<br/>
    /// NOTE: Some keys return implementation specific fallbacks
    /// </summary>
    /// <param name="vk">the virtual key</param>
    /// <returns>the friendly name of the key</returns>
    public static string GetFriendlyName(int vk)
    {
        EnsureLoaded();
        return instance.GetFriendlyName(vk);
    }

    internal static void Dispose()
    {
        instance?.Dispose();
        instance = null;
    }
}
