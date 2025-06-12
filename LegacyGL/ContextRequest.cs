namespace LegacyGL;

public struct ContextRequest
{
    public int GLMajorVer = 1;
    public int GLMinorVer = 1;
    public bool Core = false;
    public bool GLES = false;
    /// <summary>
    /// Color buffer size
    /// </summary>
    public byte ColorBits = 32;
    /// <summary>
    /// Depth buffer size, 0 for none
    /// </summary>
    public byte DepthBits = 24;
    /// <summary>
    /// Stencil buffer size, 0 for none
    /// </summary>
    public byte StencilBits = 0;

    public ContextRequest()
    {
    }
}