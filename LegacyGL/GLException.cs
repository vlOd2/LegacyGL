// Copyright (c) vlOd
// Licensed under the GNU Lesser General Public License, version 3.0

namespace LegacyGL;

public class GLException : Exception
{
    public GLException(string msg) : base(msg) { }

    public GLException(string msg, Exception inner) : base(msg, inner) { }
}
