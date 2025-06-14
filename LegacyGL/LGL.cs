﻿// Copyright (c) vlOd
// Licensed under the GNU Lesser General Public License, version 3.0

using LegacyGL.Internal;
using LegacyGL.Internal.Abstract;
using LegacyGL.Internal.Win32Impl;
using LegacyGL.Internal.X11Impl;
using System.Drawing;
using System.Text.RegularExpressions;

namespace LegacyGL;

/// <summary>
/// Manages the GL context and viewport
/// </summary>
public static partial class LGL
{
    internal const int DEFAULT_WIDTH = 800;
    internal const int DEFAULT_HEIGHT = 600;
    private static ILGL instance;
    /// <summary>
    /// Handler for detailed error information<br/>
    /// Default implementation prints everything to stderr
    /// </summary>
    public static Action<string> ErrorLogHandler = (s) => Console.Error.WriteLine($"[LegacyGL] {s}");
    [GeneratedRegex(@"(\d)\.(\d)(?:\.\d)?(?= )")]
    private static partial Regex GLVersionRegex();
    #region Properties
    /// <summary>
    /// The size of the viewport
    /// </summary>
    public static Size Size
    {
        get => GetPropSafe(instance.Size);
        set => EnsureLoaded(() => instance.Size = value);
    }
    /// <summary>
    /// The title of the viewport
    /// </summary>
    public static string Title
    {
        get => GetPropSafe(instance.Title);
        set => EnsureLoaded(() => instance.Title = value);
    }
    /// <summary>
    /// The icon of the viewport
    /// </summary>
    public static nint Icon
    {
        get => GetPropSafe(instance.Icon);
        set => EnsureLoaded(() => instance.Icon = value);
    }
    /// <summary>
    /// If the viewport can be resized by the user
    /// </summary>
    public static bool Resizable
    {
        get => GetPropSafe(instance.Resizable);
        set => EnsureLoaded(() => instance.Resizable = value);
    }
    /// <summary>
    /// If the viewport has been requested to close
    /// </summary>
    public static bool ShouldClose => GetPropSafe(instance.ShouldClose);
    /// <summary>
    /// If the viewport is currently focused
    /// </summary>
    public static bool Focused => GetPropSafe(instance.Focused);
    /// <summary>
    /// The system text clipboard
    /// </summary>
    public static string ClipboardContent
    {
        get => GetPropSafe(instance.ClipboardContent);
        set => EnsureLoaded(() => instance.ClipboardContent = value);
    }
    /// <summary>
    /// Whether OpenAL APIs are available and can be used
    /// </summary>
    public static bool IsALAvailable => ALLoader.Loaded;
    #endregion

    /// <summary>
    /// Loads the LegacyGL context and the viewport
    /// </summary>
    public static void Init(ref ContextRequest ctxReq)
    {
        if (instance != null)
            throw new GLException("Context already loaded");

        ILGL impl;
        if (OperatingSystem.IsWindows())
        {
            if (Thread.CurrentThread.GetApartmentState() == ApartmentState.Unknown)
                Console.WriteLine("Unknown thread apartment state! The game might freeze!");
            else if (Thread.CurrentThread.GetApartmentState() != ApartmentState.STA)
                throw new ThreadStateException("Apartment state must be STA");
            impl = new W32LGL();
        }
        else if (OperatingSystem.IsLinux())
            impl = new X11LGL();
        else
            throw new PlatformNotSupportedException("Operating system is not supported");

        try
        {
            impl.Init(ref ctxReq);
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

    internal static (int, int) ParseGLVersion(string str)
    {
        Match match = GLVersionRegex().Match(str);
        if (!match.Success)
            throw new GLException("Could not figure out OpenGL version");
        int major = int.Parse(match.Groups[1].Value);
        int minor = int.Parse(match.Groups[2].Value);
        return (major, minor);
    }
}
