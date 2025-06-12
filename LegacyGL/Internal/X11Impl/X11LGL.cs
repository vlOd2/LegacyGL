// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

using LegacyGL.Internal.Abstract;
using ZeroCraft.LegacyGL.Internal.X11Impl;

namespace LegacyGL.Internal.X11Impl;

internal class X11LGL : ILGL
{
    internal X11Viewport viewport;
    private X11NativeAPILoader apiLoader;
    private X11Keyboard keyboard;
    private X11Mouse mouse;
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
    public string ClipboardContent { get => ""; set { } }
    public IKeyboard Keyboard => keyboard;
    public IMouse Mouse => mouse;
    public INativeAPILoader APILoader => apiLoader;
    #endregion

    public void Init(ref ContextRequest ctxReq) 
    {
        try
        {
            apiLoader = new X11NativeAPILoader();
            viewport = new X11Viewport();
            keyboard = new X11Keyboard();
            mouse = new X11Mouse();
        }
        catch (Exception)
        {
            Dispose();
            throw;
        }
    }

    public void Center() => viewport.Center();

    public void Flush() => viewport.Swap();

    public void Poll() => viewport.Poll();

    public void Dispose()
    {
        viewport?.Dispose();
        apiLoader = null;
        keyboard = null;
        mouse = null;
        viewport = null;
    }
}