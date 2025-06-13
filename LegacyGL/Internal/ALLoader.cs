// Copyright (c) vlOd
// Licensed under the GNU Lesser General Public License, version 3.0

using LegacyGL.Bindings;
using LegacyGL.Internal.Abstract;
using System.Reflection;

namespace LegacyGL.Internal;

internal static class ALLoader
{
    public static bool Loaded;

    public static void Load(INativeAPILoader loader)
    {
        if (!OperatingSystem.IsWindows())
            throw new PlatformNotSupportedException("Not available on non Windows platforms");

        foreach (FieldInfo field in typeof(AL).GetFields(LGLNativeAPI.BINDING_FLAGS))
        {
            LGLNativeAPI nativeAPI = field.GetCustomAttribute<LGLNativeAPI>();
            if (nativeAPI == null) 
                continue;

            nint handle = loader.LoadAL(nativeAPI.Name);
            if (handle == nint.Zero)
                throw new GLException($"Could not find AL method: {nativeAPI.Name}");

            field.SetValue(null, handle);
        }

        foreach (FieldInfo field in typeof(ALC).GetFields(LGLNativeAPI.BINDING_FLAGS))
        {
            LGLNativeAPI nativeAPI = field.GetCustomAttribute<LGLNativeAPI>();
            if (nativeAPI == null) 
                continue;

            nint handle = loader.LoadAL(nativeAPI.Name);
            if (handle == nint.Zero)
                throw new GLException($"Could not find ALC method: {nativeAPI.Name}");

            field.SetValue(null, handle);
        }

        Loaded = true;
    }

    public static void Unload()
    {
        Loaded = false;

        foreach (FieldInfo field in typeof(AL).GetFields(LGLNativeAPI.BINDING_FLAGS))
        {
            LGLNativeAPI nativeAPI = field.GetCustomAttribute<LGLNativeAPI>();
            if (nativeAPI == null) 
                continue;
            field.SetValue(null, nint.Zero);
        }

        foreach (FieldInfo field in typeof(ALC).GetFields(LGLNativeAPI.BINDING_FLAGS))
        {
            LGLNativeAPI nativeAPI = field.GetCustomAttribute<LGLNativeAPI>();
            if (nativeAPI == null) 
                continue;
            field.SetValue(null, nint.Zero);
        }
    }
}