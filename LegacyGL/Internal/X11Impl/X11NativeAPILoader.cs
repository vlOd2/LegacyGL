// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

using LegacyGL.Internal.Abstract;
using System.Runtime.InteropServices;
using XLibSharp;

namespace LegacyGL.Internal.X11Impl;

internal class X11NativeAPILoader : INativeAPILoader
{
    public nint LoadGL(string name) => GLX.glXGetProcAddress(name);

    public T LoadDelegateGL<T>(string name) where T : Delegate
    {
        nint ptr = LoadGL(name);
        if (ptr == nint.Zero)
            return null;
        return Marshal.GetDelegateForFunctionPointer<T>(ptr);
    }

    // TODO: OpenAL on Linux
    public nint LoadAL(string name) => nint.Zero;
}
