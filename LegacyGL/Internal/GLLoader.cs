using LegacyGL.Internal.Abstract;
using System.Data.SqlTypes;
using System.Reflection;

namespace LegacyGL.Internal;

internal static class GLLoader
{
    public static void Load(INativeAPILoader loader, bool gles)
    {
        nint invalidHandle = nint.Zero;
        if (OperatingSystem.IsLinux())
            invalidHandle = loader.LoadGL("glInvalidFunctionThatIsGuaranteedToNotExist");

        foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
        {
            GLFeature feature = type.GetCustomAttribute<GLFeature>();

            if (feature == null || feature.IsGLES != gles)
                continue;

            foreach (FieldInfo field in type.GetFields(LGLNativeAPI.BINDING_FLAGS))
            {
                LGLNativeAPI nativeAPI = field.GetCustomAttribute<LGLNativeAPI>();
                if (nativeAPI == null)
                    continue;

                nint handle;
                using (LGLString str = new(nativeAPI.Name))
                    handle = loader.LoadGL(str);
                // This only officially works on Win32, as GLX returns a stub pointer
                // This workaround might not always work, as some GLX implementations generate a stub per call
                // TODO: Properly check with GL_EXTENSIONS or similar
                if (handle == nint.Zero || handle == invalidHandle)
                    continue;

                field.SetValue(null, handle);
            }
        }
    }

    public static void Unload()
    {
        foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
        {
            if (type.GetCustomAttribute<GLFeature>() == null)
                continue;

            foreach (FieldInfo field in type.GetFields(LGLNativeAPI.BINDING_FLAGS))
            {
                LGLNativeAPI nativeAPI = field.GetCustomAttribute<LGLNativeAPI>();
                if (nativeAPI == null) 
                    continue;
                field.SetValue(null, nint.Zero);
            }
        }
    }
}