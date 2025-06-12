// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

using System.Drawing;
using XLibSharp;
using ZeroCraft.LegacyGL.Internal.X11Impl;

namespace LegacyGL.Internal.X11Impl;

internal class X11LGL : ILGL
{
    internal X11Viewport viewport;
    private X11NativeAPILoader glLookup;
    private GLAPILoader apiLoader;
    
    #region Properties
    public int VWidth
    {
        get => viewport.Width;
        set => viewport.Width = value;
    }
    public int VHeight
    {
        get => viewport.Height;
        set => viewport.Height = value;
    }
    public string VTitle { get => viewport.Title; set => viewport.Title = value; }
    public nint VIcon { get; set; }
    public bool VResizable { get => viewport.Resizable; set => viewport.Resizable = value; }
    public bool ShouldClose => viewport.ShouldClose;
    public string ClipboardContent { get; set; }
    #endregion
    
    public void Init() 
    {
        try
        {
            glLookup = new X11NativeAPILoader();
            apiLoader = new GLAPILoader(glLookup);
            viewport = new X11Viewport();
            apiLoader.Load();
        }
        catch (Exception e)
        {
            Dispose();
            throw;
        }
    }

    public IKeyboard GetKeyboard() 
    {
        X11Keyboard keyboard = new X11Keyboard();
        return keyboard;
    }

    public IMouse GetMouse() 
    {
        X11Mouse mouse = new X11Mouse();
        return mouse;
    }

    public void Center() => viewport.Center();

    public void Flush() => viewport.Swap();

    public void Poll() => viewport.Poll();

    public void Dispose()
    {
        apiLoader?.Unload();
        viewport?.Dispose();
        glLookup = null;
        viewport = null;
    }
}