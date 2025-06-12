using System.Reflection;

namespace LegacyGL.Internal;

[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
internal class LGLNativeAPI : Attribute
{
    public const BindingFlags BINDING_FLAGS = BindingFlags.NonPublic | BindingFlags.Static;
    public string Name { get; private set; }

    public LGLNativeAPI(string name)
    {
        Name = name;
    }
}