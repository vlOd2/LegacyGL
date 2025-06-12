// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

namespace LegacyGL.Internal;

internal interface ILGL : IDisposable
{
    int VWidth { get; set; }
    int VHeight { get; set; }
    string VTitle { get; set; }
    nint VIcon { get; set; }
    bool VResizable { get; set; }
    bool ShouldClose { get; }
    string ClipboardContent { get; set; }
    IKeyboard Keyboard { get; }
    IMouse Mouse { get; }
    INativeAPILoader APILoader { get; }

    void Init();
    void Center();
    void Flush();
    void Poll();
}
