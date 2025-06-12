// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

using System;
using System.Runtime.InteropServices;

namespace LegacyGL.Internal;

internal static class Utils
{
    private static readonly DateTime TIME_EPOCH = new DateTime(1970, 1, 1);

    //public static bool IsRawInputAvailable()
    //{
    //    Version osVer = Environment.OSVersion.Version;
    //    if (osVer.Major < 5 || (osVer.Major == 5 && osVer.Minor < 1))
    //        return false;

    //    nint u32Lib = W32Libraries.GetModuleHandle("user32.dll");
    //    if (u32Lib == 0)
    //        return false;

    //    nint getRawInputData = W32Libraries.GetProcAddress(u32Lib, "GetRawInputData");
    //    nint registerRawInputDevices = W32Libraries.GetProcAddress(u32Lib, "RegisterRawInputDevices");
    //    nint getRawInputDeviceList = W32Libraries.GetProcAddress(u32Lib, "GetRawInputDeviceList");
    //    return getRawInputData != 0 &&
    //        registerRawInputDevices != 0 &&
    //        getRawInputDeviceList != 0;
    //}

    public static long UnixMillis => (long)(DateTime.UtcNow - TIME_EPOCH).TotalMilliseconds;
}
