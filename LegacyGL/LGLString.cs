// Copyright (c) vlOd
// Licensed under the GNU Lesser General Public License, version 3.0

using System.Runtime.InteropServices;
using System.Text;

namespace LegacyGL;

/// <summary>
/// Convenience class to allow for easy interop with native ASCII strings
/// </summary>
public unsafe class LGLString : IDisposable
{
    private nint data;
    private bool notOwned;
    public int Length { get; private set; }
    /// <summary>
    /// Reads a managed string from the pointer
    /// </summary>
    public string Data => Marshal.PtrToStringAnsi(data);
    /// <summary>
    /// The pointer behind this string
    /// </summary>
    public byte* RawData => (byte*)data;

    /// <summary>
    /// Imports a native null terminated string
    /// </summary>
    /// <param name="data">the native string</param>
    public LGLString(byte* data)
    {
        this.data = (nint)data;
        int idx = 0;
        while (data[idx++] != 0x00) ;
        Length = idx - 1;
        notOwned = true;
    }

    /// <summary>
    /// Allocates a native string from the given managed string
    /// </summary>
    /// <param name="data">the managed string to allocate from</param>
    public LGLString(string data)
    {
        this.data = Marshal.StringToHGlobalAnsi(data);
        Length = Encoding.ASCII.GetByteCount(data);
    }

    /// <summary>
    /// Allocates a native string with the given size
    /// </summary>
    /// <param name="size">the size of the string</param>
    public LGLString(int size)
    {
        data = Marshal.AllocHGlobal(size);
        Length = size;
    }

    ~LGLString()
    {
        Dispose(false);
    }

    public static implicit operator byte*(LGLString str) => str.RawData;

    public static implicit operator string(LGLString str) => str.Data;

    public static implicit operator LGLString(byte* data) => new(data);

    public static implicit operator LGLString(string data) => new(data);

    public override int GetHashCode() => Data.GetHashCode();

    public override string ToString() => Data;

    protected virtual void Dispose(bool disposing)
    {
        if (notOwned || data == nint.Zero)
            return;
        Marshal.FreeHGlobal(data);
        data = nint.Zero;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}