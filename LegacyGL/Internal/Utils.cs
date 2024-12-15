// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

using System;
using System.Runtime.InteropServices;

namespace LegacyGL.Internal
{
    internal static class Utils
    {
        private static DateTime TimeEpoch = new DateTime(1970, 1, 1);

        public static void GLInitFailed(string function)
        {
            int error = Marshal.GetLastWin32Error();
            Console.Error.WriteLine($"ERROR @ {function}: {error}");
            MsgBox.Show(
                $"Failed to initialize OpenGL{Environment.NewLine}" +
                $"Failed function: {function}{Environment.NewLine}" +
                $"Error: {error}",
                "OpenGL Error", MsgBoxBtn.OK, MsgBoxIcon.Error
            );
            throw new GLException($"OpenGL initialization failed");
        }

        //public static bool IsRawInputAvailable()
        //{
        //    Version osVer = Environment.OSVersion.Version;
        //    if (osVer.Major < 5 || (osVer.Major == 5 && osVer.Minor < 1))
        //        return false;

        //    nint u32Lib = W32Libraries.GetModuleHandle("user32.dll");
        //    if (u32Lib == NULLPTR)
        //        return false;

        //    nint getRawInputData = W32Libraries.GetProcAddress(u32Lib, "GetRawInputData");
        //    nint registerRawInputDevices = W32Libraries.GetProcAddress(u32Lib, "RegisterRawInputDevices");
        //    nint getRawInputDeviceList = W32Libraries.GetProcAddress(u32Lib, "GetRawInputDeviceList");
        //    return getRawInputData != NULLPTR &&
        //        registerRawInputDevices != NULLPTR &&
        //        getRawInputDeviceList != NULLPTR;
        //}

        public static long UnixMillis => (long)(DateTime.UtcNow - TimeEpoch).TotalMilliseconds;
    }
}
