// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

using LegacyGL.Internal.Win32Impl.Native;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace LegacyGL.Internal.Win32Impl;

internal class W32NativeAPILoader : INativeAPILoader
{
    private nint glLib;
    private nint alLib;

    public W32NativeAPILoader(nint glLib, nint alLib)
    {
        this.glLib = glLib;
        this.alLib = alLib;
    }

    public nint LoadGL(string name)
    {
        nint ptr = W32WGL.wglGetProcAddress(name);
        // GL1.0/1.1 functions have to be loaded from the GL library directly, retarded, I know
        if (ptr == nint.Zero)
            ptr = W32Libraries.GetProcAddress(glLib, name);
        return ptr;
    }

    public T LoadDelegateGL<T>(string name) where T : Delegate
    {
        nint ptr = LoadGL(name);
        if (ptr == nint.Zero)
            return null;
        return Marshal.GetDelegateForFunctionPointer<T>(ptr);
    }

    public nint LoadAL(string name) => W32Libraries.GetProcAddress(alLib, name);
}
