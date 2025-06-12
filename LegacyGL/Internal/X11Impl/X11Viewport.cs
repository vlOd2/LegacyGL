// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

using System.Drawing;
using System.Runtime.InteropServices;
using XLibSharp;
using static XLibSharp.XLib;
using static XLibSharp.GLX;

namespace LegacyGL.Internal.X11Impl;

public class X11Viewport : IDisposable
{
    private static readonly int[] GLX_ATTRIBS = { GLX_RGBA, GLX_DEPTH_SIZE, 24, GLX_DOUBLEBUFFER, 0 };
    private nint display;
    private ulong rootWindow;
    private ulong colorMap;
    private ulong window;
    private nint visualInfoPtr;
    private XVisualInfo visualInfo;
    private nint glContext;
    private XAtom wmDeleteWindow;
    #region Properties
    public int Width
    {
        get
        {
            XGetWindowAttributes(display, window, out XWindowAttributes attribs);
            return (int)attribs.width;
        }
        set
        {
            XWindowChanges changes = new XWindowChanges()
            {
                width = value
            };
            XConfigureWindow(display, window, (ulong)XWindowChangesMask.CWWidth, ref changes);
            XSync(display, false);
        }
    }
    public int Height
    {
        get
        {
            XGetWindowAttributes(display, window, out XWindowAttributes attribs);
            return (int)attribs.height;
        }
        set
        {
            XWindowChanges changes = new XWindowChanges()
            {
                height = value
            };
            XConfigureWindow(display, window, (ulong)XWindowChangesMask.CWHeight, ref changes);
            XSync(display, false);
        }
    }
    public bool ShouldClose { get; private set; }
    public bool Resizable
    {
        get
        {
            nint hintsPtr = XAllocSizeHints();
            XSizeHints hints = Marshal.PtrToStructure<XSizeHints>(hintsPtr);
            XGetWMNormalHints(display, window, ref hints, out long supplied);

            bool status = false;
            if ((supplied & (long)XSizeHintsFlags.PMinSize) == (long)XSizeHintsFlags.PMinSize &&
                (supplied & (long)XSizeHintsFlags.PMaxSize) == (long)XSizeHintsFlags.PMaxSize)
            {
                status = hints.max_width == 0 || hints.max_height == 0 ||
                         hints.min_width != hints.max_width ||
                         hints.min_height != hints.max_height;
                Console.WriteLine(status);
            }

            XFree(hintsPtr);
            return status;
        }
        set
        {
            int w = Width;
            int h = Height;
            nint hintsPtr = XAllocSizeHints();
            XSizeHints hints = Marshal.PtrToStructure<XSizeHints>(hintsPtr);
            hints.flags = value ? 0 : (long)(XSizeHintsFlags.PMinSize | XSizeHintsFlags.PMaxSize);
            hints.min_width = value ? 0 : w;
            hints.min_height = value ? 0 : h;
            hints.max_width = value ? 0 : w;
            hints.max_height = value ? 0 : h;
            XSetWMNormalHints(display, window, ref hints);
            XFree(hintsPtr);
            XSync(display, false);
        }
    }
    public string Title
    {
        get
        {
            nint ptr = Marshal.AllocHGlobal(256);
            string heapStr = Marshal.PtrToStringAnsi(ptr);
            XFetchName(display, window, ref heapStr);
            string str = new string(heapStr.ToCharArray());
            Marshal.FreeHGlobal(ptr);
            return str;
        }
        set
        {
            XStoreName(display, window, value);
            XSync(display, false);
        }
    }
    #endregion

    public X11Viewport()
    {
        display = XOpenDisplay(null);
        if (display == nint.Zero)
            throw new GLException("Failed to open display");
        rootWindow = XDefaultRootWindow(display);
        try
        {
            PrepareVisual();
            CreateWindow();
            CreateGLContext();
        }
        catch
        {
            Dispose();
            throw;
        }
    }

    private void PrepareVisual()
    {
        visualInfoPtr = glXChooseVisual(display, 0, GLX_ATTRIBS);
        if (visualInfoPtr == nint.Zero)
            throw new IOException("Could not choose appropriate visual");
        visualInfo = Marshal.PtrToStructure<XVisualInfo>(visualInfoPtr);
        colorMap = XCreateColormap(display, rootWindow, visualInfo.visual, XColormapAlloc.AllocNone);
    }

    private void CreateWindow()
    {
        XAttributeMask attribMask = XAttributeMask.CW_BACK_PIXEL |
                                    XAttributeMask.CW_EVENT_MASK |
                                    XAttributeMask.CW_COLORMAP;
        XSetWindowAttributes attribs = new()
        {
            background_pixel = 0xFF_00_00_00,
            event_mask = XEventMask.KeyPressMask | XEventMask.KeyReleaseMask | 
                         XEventMask.ExposureMask | XEventMask.StructureNotifyMask,
            colormap = colorMap
        };

        window = XCreateWindow(display, rootWindow,
            0, 0, 800, 600,
            0, visualInfo.depth, 1, visualInfo.visual,
            attribMask, ref attribs);
        XMapWindow(display, window);
        XStoreName(display, window, "Game");

        wmDeleteWindow = XInternAtom(display, "WM_DELETE_WINDOW", false);
        if (XSetWMProtocols(display, window, ref wmDeleteWindow, 1) == XStatus.Failure)
            Console.Error.WriteLine("WM_DELETE_WINDOW failed");

        XSync(display, false);
    }

    private void CreateGLContext()
    {
        glContext = glXCreateContext(display, visualInfoPtr, 0, true);
        glXMakeCurrent(display, window, glContext);
    }

    public void Center()
    {
    }

    private void HandleEvent(XEvent type, nint ptr)
    {
        switch (type)
        {
            case XEvent.ClientMessage:
            {
                XClientMessageEvent e = Marshal.PtrToStructure<XClientMessageEvent>(ptr);
                if ((ulong)e.data == (ulong)wmDeleteWindow)
                    ShouldClose = true;
                break;
            }
            
            case XEvent.KeyPress:
            {
                XKeyEvent e = Marshal.PtrToStructure<XKeyEvent>(ptr);
                Console.WriteLine((char)XLookupKeysym(ref e, 0));
                break;
            }
            
            case XEvent.KeyRelease:
            {
                XKeyEvent e = Marshal.PtrToStructure<XKeyEvent>(ptr);
                Console.WriteLine((char)XLookupKeysym(ref e, 0));
                break;
            }
        }
    }

    public void Poll()
    {
        nint eventPtr = Marshal.AllocHGlobal(24 * sizeof(long));
        if (!XCheckTypedWindowEvent(display, window, XEvent.ClientMessage, eventPtr) &&
            !XCheckMaskEvent(display, (XEventMask)long.MaxValue, eventPtr))
            return;
        HandleEvent((XEvent)Marshal.ReadInt32(eventPtr), eventPtr);
    }

    public void Swap() => glXSwapBuffers(display, window);

    public void Dispose()
    {
        if (glContext != nint.Zero)
        {
            glXMakeCurrent(display, 0, nint.Zero);
            glXDestroyContext(display, glContext);
        }

        XFreeColormap(display, colorMap);
        XDestroyWindow(display, window);
        XCloseDisplay(display);
    }
}