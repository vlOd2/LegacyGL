// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

namespace LegacyGL.Internal;

internal interface INativeAPILoader
{
    nint LoadGL(string name);
    
    T LoadDelegateGL<T>(string name) where T : Delegate;

    nint LoadAL(string name);
}
