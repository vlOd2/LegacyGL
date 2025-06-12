namespace LegacyGL.Internal;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
internal class GLFeature : Attribute
{
    public bool IsGLES { get; private set; }

    public GLFeature(bool isGLES)
    {
        IsGLES = isGLES;
    }
}