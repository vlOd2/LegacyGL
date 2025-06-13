// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

using LegacyGL.Internal.Abstract;
using System.Drawing;
using ZeroCraft.LegacyGL.Internal.X11Impl;

namespace LegacyGL.Internal.X11Impl;

internal class X11LGL : ILGL
{
    internal X11Viewport viewport;
    private X11NativeAPILoader apiLoader;
    private X11Keyboard keyboard;
    private X11Mouse mouse;
    #region Properties
    public Size Size
    {
        get => new(viewport.Width, viewport.Height);
        set
        {
            viewport.Width = value.Width;
            viewport.Height = value.Height;
        }
    }
    public string Title { get => viewport.Title; set => viewport.Title = value; }
    public nint Icon { get; set; }
    public bool Resizable { get => viewport.Resizable; set => viewport.Resizable = value; }
    public bool ShouldClose => viewport.ShouldClose;
    // TODO: X11 FOCUSED
    public bool Focused => true;
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
            GLLoader.Load(apiLoader, false);
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
        GLLoader.Unload();
        apiLoader = null;
        keyboard = null;
        mouse = null;
        viewport = null;
    }
}