namespace LegacyGL.Internal;

[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
internal class LGLNativeAPI : Attribute
{
    public string Name { get; private set; }

    public LGLNativeAPI(string name)
    {
        Name = name;
    }
}