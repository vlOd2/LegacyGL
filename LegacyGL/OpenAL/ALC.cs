// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

using System;
using System.Runtime.InteropServices;

namespace LegacyGL.OpenAL
{
    public static unsafe class ALC
    {
        public const int ALC_FREQUENCY = 0x1007;
        public const int ALC_REFRESH = 0x1008;
        public const int ALC_SYNC = 0x1009;
        public const int ALC_MONO_SOURCES = 0x1010;
        public const int ALC_STEREO_SOURCES = 0x1011;
        public const int ALC_NO_ERROR = 0;
        public const int ALC_INVALID_DEVICE = 0xA001;
        public const int ALC_INVALID_CONTEXT = 0xA002;
        public const int ALC_INVALID_ENUM = 0xA003;
        public const int ALC_INVALID_VALUE = 0xA004;
        public const int ALC_OUT_OF_MEMORY = 0xA005;
        public const int ALC_DEFAULT_DEVICE_SPECIFIER = 0x1004;
        public const int ALC_DEVICE_SPECIFIER = 0x1005;
        public const int ALC_EXTENSIONS = 0x1006;
        public const int ALC_MAJOR_VERSION = 0x1000;
        public const int ALC_MINOR_VERSION = 0x1001;
        public const int ALC_ATTRIBUTES_SIZE = 0x1002;
        public const int ALC_ALL_ATTRIBUTES = 0x1003;
        public const int ALC_DEFAULT_ALL_DEVICES_SPECIFIER = 0x1012;
        public const int ALC_ALL_DEVICES_SPECIFIER = 0x1013;
        public const int ALC_CAPTURE_DEVICE_SPECIFIER = 0x310;
        public const int ALC_CAPTURE_DEFAULT_DEVICE_SPECIFIER = 0x311;
        public const int ALC_CAPTURE_SAMPLES = 0x312;

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr alcCreateContext(IntPtr device, int* attrlist);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool alcMakeContextCurrent(IntPtr context);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alcProcessContext(IntPtr context);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alcSuspendContext(IntPtr context);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alcDestroyContext(IntPtr context);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr alcGetCurrentContext();

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr alcGetContextsDevice(IntPtr context);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr alcOpenDevice(string devicename);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool alcCloseDevice(IntPtr device);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int alcGetError(IntPtr device);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool alcIsExtensionPresent(IntPtr device, string extname);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* alcGetProcAddress(IntPtr device, string funcname);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int alcGetEnumValue(IntPtr device, string enumname);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern string alcGetString(IntPtr device, int param);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alcGetIntegerv(IntPtr device, int param, int size, int* data);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr alcCaptureOpenDevice(string devicename, uint frequency, int format, int buffersize);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool alcCaptureCloseDevice(IntPtr device);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alcCaptureStart(IntPtr device);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alcCaptureStop(IntPtr device);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alcCaptureSamples(IntPtr device, void* buffer, int samples);
    }
}
