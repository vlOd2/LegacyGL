// Copyright (c) vlOd
// Licensed under the GNU Lesser General Public License, version 3.0

using System.Runtime.InteropServices;

namespace LegacyGL;

public static class MsgBox
{
    private const int MB_ICONINFORMATION = 64;
    private const int MB_SETFOREGROUND = 65536;
    private const int MB_ICONQUESTION = 32;
    private const int MB_ICONWARNING = 48;
    private const int MB_TASKMODAL = 8192;
    private const int MB_ICONERROR = 16;
    private const int MB_OKCANCEL = 1;
    private const int MB_TOPMOST = 262144;
    private const int MB_YESNO = 4;
    private const int MB_OK = 0;

    [DllImport("user32.dll", EntryPoint = "MessageBoxA")]
    public static extern int W32_MessageBoxA(nint hWnd,
        [In()][MarshalAs(UnmanagedType.LPStr)] string lpText,
        [In()][MarshalAs(UnmanagedType.LPStr)] string lpCaption,
        uint uType);

    public static void Show(string body, string title, MsgBoxBtn buttons, MsgBoxIcon icon) 
    {
        // TODO: X11 message box, maybe use the GTK one????
        if (OperatingSystem.IsWindows())
            W32Show(body, title, buttons, icon);
        else
            Console.WriteLine($"[{icon}] {title} - {body}");
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

        W32_MessageBoxA(nint.Zero, body, title, type);
    }
}
