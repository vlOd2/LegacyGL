// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

using System.Runtime.InteropServices;

namespace LegacyGL.OpenAL
{
    public unsafe static class AL
    {
        public const int AL_SOURCE_RELATIVE = 0x202;
        public const int AL_CONE_INNER_ANGLE = 0x1001;
        public const int AL_CONE_OUTER_ANGLE = 0x1002;
        public const int AL_PITCH = 0x1003;
        public const int AL_POSITION = 0x1004;
        public const int AL_DIRECTION = 0x1005;
        public const int AL_VELOCITY = 0x1006;
        public const int AL_LOOPING = 0x1007;
        public const int AL_BUFFER = 0x1009;
        public const int AL_GAIN = 0x100A;
        public const int AL_MIN_GAIN = 0x100D;
        public const int AL_MAX_GAIN = 0x100E;
        public const int AL_ORIENTATION = 0x100F;
        public const int AL_CHANNEL_MASK = 0x3000;
        public const int AL_SOURCE_STATE = 0x1010;
        public const int AL_INITIAL = 0x1011;
        public const int AL_PLAYING = 0x1012;
        public const int AL_PAUSED = 0x1013;
        public const int AL_STOPPED = 0x1014;
        public const int AL_BUFFERS_QUEUED = 0x1015;
        public const int AL_BUFFERS_PROCESSED = 0x1016;
        public const int AL_SEC_OFFSET = 0x1024;
        public const int AL_SAMPLE_OFFSET = 0x1025;
        public const int AL_BYTE_OFFSET = 0x1026;
        public const int AL_SOURCE_TYPE = 0x1027;
        public const int AL_STATIC = 0x1028;
        public const int AL_STREAMING = 0x1029;
        public const int AL_UNDETERMINED = 0x1030;
        public const int AL_FORMAT_MONO8 = 0x1100;
        public const int AL_FORMAT_MONO16 = 0x1101;
        public const int AL_FORMAT_STEREO8 = 0x1102;
        public const int AL_FORMAT_STEREO16 = 0x1103;
        public const int AL_REFERENCE_DISTANCE = 0x1020;
        public const int AL_ROLLOFF_FACTOR = 0x1021;
        public const int AL_CONE_OUTER_GAIN = 0x1022;
        public const int AL_MAX_DISTANCE = 0x1023;
        public const int AL_FREQUENCY = 0x2001;
        public const int AL_BITS = 0x2002;
        public const int AL_CHANNELS = 0x2003;
        public const int AL_SIZE = 0x2004;
        public const int AL_UNUSED = 0x2010;
        public const int AL_PENDING = 0x2011;
        public const int AL_PROCESSED = 0x2012;
        public const int AL_NO_ERROR = 0;
        public const int AL_INVALID_NAME = 0xA001;
        public const int AL_ILLEGAL_ENUM = 0xA002;
        public const int AL_INVALID_ENUM = 0xA002;
        public const int AL_INVALID_VALUE = 0xA003;
        public const int AL_ILLEGAL_COMMAND = 0xA004;
        public const int AL_INVALID_OPERATION = 0xA004;
        public const int AL_OUT_OF_MEMORY = 0xA005;
        public const int AL_VENDOR = 0xB001;
        public const int AL_VERSION = 0xB002;
        public const int AL_RENDERER = 0xB003;
        public const int AL_EXTENSIONS = 0xB004;
        public const int AL_DOPPLER_FACTOR = 0xC000;
        public const int AL_DOPPLER_VELOCITY = 0xC001;
        public const int AL_SPEED_OF_SOUND = 0xC003;
        public const int AL_DISTANCE_MODEL = 0xD000;
        public const int AL_INVERSE_DISTANCE = 0xD001;
        public const int AL_INVERSE_DISTANCE_CLAMPED = 0xD002;
        public const int AL_LINEAR_DISTANCE = 0xD003;
        public const int AL_LINEAR_DISTANCE_CLAMPED = 0xD004;
        public const int AL_EXPONENT_DISTANCE = 0xD005;
        public const int AL_EXPONENT_DISTANCE_CLAMPED = 0xD006;

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alEnable(int capability);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alDisable(int capability);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool alIsEnabled(int capability);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern string alGetString(int param);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetBooleanv(int param, bool* data);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetIntegerv(int param, int* data);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetFloatv(int param, float* data);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetDoublev(int param, double* data);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool alGetBoolean(int param);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int alGetInteger(int param);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern float alGetFloat(int param);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double alGetDouble(int param);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int alGetError();

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool alIsExtensionPresent(string extname);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* alGetProcAddress(string fname);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int alGetEnumValue(string ename);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alListenerf(int param, float @value);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alListener3f(int param, float @value1, float @value2, float @value3);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alListenerfv(int param, float* @values);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alListeneri(int param, int @value);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alListener3i(int param, int @value1, int @value2, int @value3);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alListeneriv(int param, int* @values);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetListenerf(int param, float* @value);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetListener3f(int param, float* @value1, float* @value2, float* @value3);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetListenerfv(int param, float* @values);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetListeneri(int param, int* @value);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetListener3i(int param, int* @value1, int* @value2, int* @value3);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetListeneriv(int param, int* @values);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGenSources(int n, uint* sources);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alDeleteSources(int n, uint* sources);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool alIsSource(uint sid);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourcef(uint sid, int param, float @value);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSource3f(uint sid, int param, float @value1, float @value2, float @value3);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourcefv(uint sid, int param, float* @values);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourcei(uint sid, int param, int @value);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSource3i(uint sid, int param, int @value1, int @value2, int @value3);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourceiv(uint sid, int param, int* @values);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetSourcef(uint sid, int param, float* @value);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetSource3f(uint sid, int param, float* @value1, float* @value2, float* @value3);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetSourcefv(uint sid, int param, float* @values);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetSourcei(uint sid, int param, int* @value);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetSource3i(uint sid, int param, int* @value1, int* @value2, int* @value3);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetSourceiv(uint sid, int param, int* @values);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourcePlayv(int ns, uint* sids);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourceStopv(int ns, uint* sids);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourceRewindv(int ns, uint* sids);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourcePausev(int ns, uint* sids);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourcePlay(uint sid);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourceStop(uint sid);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourceRewind(uint sid);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourcePause(uint sid);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourceQueueBuffers(uint sid, int numEntries, uint* bids);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSourceUnqueueBuffers(uint sid, int numEntries, uint* bids);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGenBuffers(int n, uint* buffers);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alDeleteBuffers(int n, uint* buffers);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool alIsBuffer(uint bid);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alBufferData(uint bid, int format, void* data, int size, int freq);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alBufferf(uint bid, int param, float @value);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alBuffer3f(uint bid, int param, float @value1, float @value2, float @value3);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alBufferfv(uint bid, int param, float* @values);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alBufferi(uint bid, int param, int @value);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alBuffer3i(uint bid, int param, int @value1, int @value2, int @value3);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alBufferiv(uint bid, int param, int* @values);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetBufferf(uint bid, int param, float* @value);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetBuffer3f(uint bid, int param, float* @value1, float* @value2, float* @value3);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetBufferfv(uint bid, int param, float* @values);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetBufferi(uint bid, int param, int* @value);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetBuffer3i(uint bid, int param, int* @value1, int* @value2, int* @value3);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alGetBufferiv(uint bid, int param, int* @values);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alDopplerFactor(float @value);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alDopplerVelocity(float @value);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alSpeedOfSound(float @value);

        [DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void alDistanceModel(int distanceModel);
    }
}
