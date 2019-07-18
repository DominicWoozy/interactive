﻿// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace WorkspaceServer.Kernel
{
    public interface IRendering
    {
        string MimeType { get; }

        object Content { get; }
    }  
}