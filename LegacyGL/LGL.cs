// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

using LegacyGL.Internal;
using LegacyGL.Internal.Win32Impl;
using LegacyGL.Internal.X11Impl;
using System;
using System.Drawing;
using System.Threading;

namespace LegacyGL;

public static class LGL
{
    private static ILGL instance;

    /// <summary>
    /// The width of the viewport
    /// </summary>
    public static int VWidth
    {
        get => GetPropSafe(instance.VWidth);
        set => EnsureLoaded(() => instance.VWidth = value);
    }
    /// <summary>
    /// The height of the viewport
    /// </summary>
    public static int VHeight
    {
        get => GetPropSafe(instance.VHeight);
        set => EnsureLoaded(() => instance.VHeight = value);
    }
    /// <summary>
    /// The title of the viewport
    /// </summary>
    public static string VTitle
    {
        get => GetPropSafe(instance.VTitle);
        set => EnsureLoaded(() => instance.VTitle = value);
    }
    /// <summary>
    /// The icon of the viewport
    /// </summary>
    public static nint VIcon
    {
        get => GetPropSafe(instance.VIcon);
        set => EnsureLoaded(() => instance.VIcon = value);
    }
    /// <summary>
    /// If the viewport can be resized by the user
    /// </summary>
    public static bool VResizable
    {
        get => GetPropSafe(instance.VResizable);
        set => EnsureLoaded(() => instance.VResizable = value);
    }
    public static bool ShouldClose => instance.ShouldClose;
    public static string ClipboardContent
    {
        get => GetPropSafe(instance.ClipboardContent);
        set => EnsureLoaded(() => instance.ClipboardContent = value);
    }

    /// <summary>
    /// Loads the LegacyGL context and the viewport
    /// </summary>
    public static void Init()
    {
        if (instance != null)
            throw new GLException("Context already loaded");

        if (Thread.CurrentThread.GetApartmentState() == ApartmentState.Unknown)
            Console.WriteLine("Unknown thread apartment state! The game might freeze!");
        else if (Thread.CurrentThread.GetApartmentState() != ApartmentState.STA)
            throw new ThreadStateException("Apartment state must be STA");

        ILGL impl;
        if (OperatingSystem.IsWindows())
            impl = new W32LGL();
        else if (OperatingSystem.IsLinux())
            impl = new X11LGL();
        else
            throw new PlatformNotSupportedException("Operating system is not supported");

        try
        {
            impl.Init();
            Mouse.Init(impl.Mouse);
            Keyboard.Init(impl.Keyboard);
            instance = impl;
        }
        catch
        {
            Dispose();
            throw;
        }
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

    /// <summary>
    /// Centers the viewport on the screen
    /// </summary>
    public static void Center()
    {
        EnsureLoaded();
        instance.Center();
    }

    /// <summary>
    /// Flushes, updates and polls the viewport
    /// </summary>
    public static void Update()
    {
        Flush();
        Poll();
    }

    /// <summary>
    /// Flushes and updates the viewport
    /// </summary>
    /// <remarks>It is recommended to use the <see cref="Update"/> method instead</remarks>
    public static void Flush()
    {
        EnsureLoaded();
        instance.Flush();
    }

    /// <summary>
    /// Polls any events
    /// </summary>
    /// <remarks>It is recommended to use the <see cref="Update"/> method instead</remarks>
    public static void Poll()
    {
        EnsureLoaded();
        instance.Poll();
        Mouse.Poll();
        Keyboard.Poll();
    }

    /// <summary>
    /// Disposes the current LegacyGL context and viewport
    /// </summary>
    public static void Dispose()
    {
        Mouse.Dispose();
        Keyboard.Dispose();
        instance?.Dispose();
        instance = null;
    }
}
