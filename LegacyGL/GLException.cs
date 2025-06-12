// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

using System;

namespace LegacyGL;

public class GLException : Exception
{
    public GLException(string msg) : base(msg) { }

    public GLException(string msg, Exception inner) : base(msg, inner) { }
}
