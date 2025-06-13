// Copyright (c) vlOd
// Licensed under the GNU Lesser General Public License, version 3.0

using LegacyGL.Internal.Abstract;
using LegacyGL.Internal.Win32Impl.Native;
using System.Runtime.InteropServices;

namespace LegacyGL.Internal.Win32Impl;

internal class W32NativeAPILoader : INativeAPILoader
{
    public nint GLLib;
    public nint ALLib;

    public W32NativeAPILoader(nint glLib)
    {
        GLLib = glLib;
    }

    public nint LoadGL(string name)
    {
        nint ptr = W32WGL.wglGetProcAddress(name);
        // GL1.0/1.1 functions have to be loaded from the GL library directly, retarded, I know
        if (ptr == nint.Zero)
            ptr = W32Libraries.GetProcAddress(GLLib, name);
        return ptr;
    }

    public T LoadDelegateGL<T>(string name) where T : Delegate
    {
        nint ptr = LoadGL(name);
        if (ptr == nint.Zero)
            return null;
        return Marshal.GetDelegateForFunctionPointer<T>(ptr);
    }

    public nint LoadAL(string name) => W32Libraries.GetProcAddress(ALLib, name);
}
