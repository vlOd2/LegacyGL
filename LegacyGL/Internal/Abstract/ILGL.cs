// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

using System.Drawing;

namespace LegacyGL.Internal.Abstract;

internal interface ILGL : IDisposable
{
    Size Size { get; set; }
    string Title { get; set; }
    nint Icon { get; set; }
    bool Resizable { get; set; }
    bool ShouldClose { get; }
    bool Focused { get; }
    string ClipboardContent { get; set; }
    IKeyboard Keyboard { get; }
    IMouse Mouse { get; }
    INativeAPILoader APILoader { get; }

    void Init(ref ContextRequest ctxReq);
    void Center();
    void Flush();
    void Poll();
}
