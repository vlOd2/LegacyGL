// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

using LegacyGL.Internal.Win32Impl.Native;
using System;
using System.Runtime.InteropServices;

namespace LegacyGL.Internal.Win32Impl
{
    internal class W32GLLookup : IGLLookup
    {
        private IntPtr glLib;

        public W32GLLookup(IntPtr glLib)
        {
            this.glLib = glLib;
        }

        public Delegate Lookup(Type delegateType, string entryPoint, bool optional = false)
        {
            string name = entryPoint;

            IntPtr funcPtr = W32WGL.wglGetProcAddress(name);
            if (funcPtr == IntPtr.Zero)
            {
                funcPtr = W32Libraries.GetProcAddress(glLib, name);
                if (funcPtr == IntPtr.Zero)
                {
                    if (optional)
                    {
                        Console.Error.WriteLine($"Optional method {name} couldn't be found");
                        return null;
                    }
                    else
                        throw new GLException($"{name} couldn't be found");
                }
            }

            return Marshal.GetDelegateForFunctionPointer(funcPtr, delegateType);
        }

        public T Lookup<T>(bool optional = false) where T : Delegate
            => (T)Lookup(typeof(T), typeof(T).Name, optional);
    }
}
