// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

using System;
using System.Drawing;

namespace LegacyGL.Internal
{
    internal interface ILGL : IDisposable
    {
        int VWidth { get; set; }
        int VHeight { get; set; }
        string VTitle { get; set; }
        nint VIcon { get; set; }
        bool VResizable { get; set; }
        bool ShouldClose { get; }
        string ClipboardContent { get; set; }

        void Init();
        IKeyboard GetKeyboard();
        IMouse GetMouse();
        void Center();
        void Flush();
        void Poll();
    }
}
