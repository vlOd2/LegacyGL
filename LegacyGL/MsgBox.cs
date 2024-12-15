// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

using System;
using System.Runtime.InteropServices;

namespace LegacyGL
{
    public enum MsgBoxBtn
    {
        OK,
        OKCancel,
        YesNo
    }

    public enum MsgBoxIcon
    {
        None,
        Question,
        Information,
        Warning,
        Error
    }

    public static class MsgBox
    {
        public const int MB_ICONINFORMATION = 64;
        public const int MB_SETFOREGROUND = 65536;
        public const int MB_ICONQUESTION = 32;
        public const int MB_ICONWARNING = 48;
        public const int MB_TASKMODAL = 8192;
        public const int MB_ICONERROR = 16;
        public const int MB_OKCANCEL = 1;
        public const int MB_TOPMOST = 262144;
        public const int MB_YESNO = 4;
        public const int MB_OK = 0;

        [DllImport("user32.dll", EntryPoint = "MessageBoxA")]
        public static extern int W32_MessageBoxA(IntPtr hWnd,
            [In()][MarshalAs(UnmanagedType.LPStr)] string lpText,
            [In()][MarshalAs(UnmanagedType.LPStr)] string lpCaption,
            uint uType);

        public static void Show(string body, string title, MsgBoxBtn buttons, MsgBoxIcon icon) 
        {
            Console.WriteLine($"{title} - {body} {buttons} {icon}");
            // W32Show(body, title, buttons, icon);
        }

        private static void W32Show(string body, string title, MsgBoxBtn buttons, MsgBoxIcon icon)
        {
            uint type = MB_TASKMODAL | MB_SETFOREGROUND | MB_TOPMOST;

            switch (buttons)
            {
                case MsgBoxBtn.OK:
                    type |= MB_OK;
                    break;
                case MsgBoxBtn.OKCancel:
                    type |= MB_OKCANCEL;
                    break;
                case MsgBoxBtn.YesNo:
                    type |= MB_YESNO;
                    break;
            }

            switch (icon)
            {
                case MsgBoxIcon.Question:
                    type |= MB_ICONQUESTION;
                    break;
                case MsgBoxIcon.Information:
                    type |= MB_ICONINFORMATION;
                    break;
                case MsgBoxIcon.Warning:
                    type |= MB_ICONWARNING;
                    break;
                case MsgBoxIcon.Error:
                    type |= MB_ICONERROR;
                    break;
            }

            W32_MessageBoxA(IntPtr.Zero, body, title, type);
        }
    }
}
