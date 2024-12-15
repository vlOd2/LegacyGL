// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

using System;
using System.Runtime.InteropServices;

namespace LegacyGL.OpenGL
{
    public unsafe class GLString : IDisposable
    {
        private bool noDispose;
        private nint data;
        public int Length { get; private set; }
        public string Data => Marshal.PtrToStringAnsi(data);
        public char* RawData => (char*)data;

        public GLString(char* data)
        {
            this.data = (nint)data;
            int idx = 0;
            while (data[idx++] != 0x00)
                ;
            Length = idx;
            noDispose = true;
        }

        public GLString(string data)
        {
            this.data = Marshal.StringToHGlobalAnsi(data);
            Length = data.Length + 1;
        }

        public GLString(int size)
        {
            data = Marshal.AllocHGlobal(size);
            Length = size;
        }

        public static implicit operator char*(GLString str) => str.RawData;

        public static implicit operator string(GLString str) => str.Data;

        public static implicit operator GLString(char* data) => new GLString(data);

        public static implicit operator GLString(string data) => new GLString(data);

        public void Dispose()
        {
            if (noDispose) return;
            Marshal.FreeHGlobal(data);
        }
    }
}
