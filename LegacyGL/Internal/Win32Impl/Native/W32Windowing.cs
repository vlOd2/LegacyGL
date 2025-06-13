// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

using LegacyGL.Internal.Win32Impl.Native.Structs;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;

namespace LegacyGL.Internal.Win32Impl.Native;

internal static class W32Windowing
{
    [DllImport("user32.dll")]
    public static extern short RegisterClassA(ref WNDCLASS lpWndClass);

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool UnregisterClassA([In()][MarshalAs(UnmanagedType.LPStr)] string lpClassName, nint hInstance);

    [DllImport("user32.dll")]
    public static extern int SetClassLongA(nint hWnd, int nIndex, int dwNewLong);

    [DllImport("user32.dll")]
    public static extern nint LoadCursorA(nint hInstance, int lpCursorName);

    [DllImport("user32.dll")]
    public static extern nint SetCursor(nint hCursor);

    [DllImport("user32.dll")]
    public static extern nint CreateWindowExA(int dwExStyle,
        [In()][MarshalAs(UnmanagedType.LPStr)] string lpClassName,
        [In()][MarshalAs(UnmanagedType.LPStr)] string lpWindowName,
        uint dwStyle, int X, int Y, int nWidth, int nHeight,
        nint hWndParent, nint hMenu, nint hInstance, nint lpParam);

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool UpdateWindow(nint hWnd);

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool DestroyWindow(nint hWnd);

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool ShowWindow(nint hWnd, int nCmdShow);

    [DllImport("user32.dll")]
    public static extern int GetWindowLongA(nint hWnd, int nIndex);

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool PeekMessageA(ref MSG lpMsg, nint hWnd, uint wMsgFilterMin, uint wMsgFilterMax, uint wRemoveMsg);

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool TranslateMessage(ref MSG lpMsg);

    [DllImport("user32.dll")]
    public static extern nint DispatchMessageA(ref MSG lpMsg);

    [DllImport("user32.dll")]
    public static extern void PostQuitMessage(int nExitCode);

    [DllImport("user32.dll")]
    public static extern nint DefWindowProcA(nint hWnd, uint Msg, nint wParam, nint lParam);

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool GetClientRect(nint hWnd, ref RECT lpRect);

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool GetWindowRect(nint hWnd, ref RECT lpRect);

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool ScreenToClient(nint hWnd, ref POINT lpPoint);

    [DllImport("user32.dll")]
    public static extern int MapWindowPoints(nint hWndFrom, nint hWndTo, ref Point lpPoints, int cPoints);

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool ClientToScreen(nint hWnd, ref POINT lpPoint);

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool SetWindowPos(nint hWnd, nint hWndInsertAfter, int X, int Y, int cx, int cy, int uFlags);

    [DllImport("user32.dll")]
    public static extern int GetWindowTextA(nint hWnd, [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpString, int nMaxCount);

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool SetWindowTextA(nint hWnd, [In()][MarshalAs(UnmanagedType.LPStr)] string lpString);

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool AdjustWindowRect(ref RECT lpRect, int dwStyle, [MarshalAs(UnmanagedType.Bool)] bool bMenu);

    [DllImport("user32.dll")]
    public static extern int SetWindowLongA(nint hWnd, int nIndex, int dwNewLong);
}
