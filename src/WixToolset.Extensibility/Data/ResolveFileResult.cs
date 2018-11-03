﻿// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.Extensibility.Data
{
    using System.Collections.Generic;

    public class ResolveFileResult
    {
        public string Path { get; set; }

        public IEnumerable<string> CheckedPaths { get; set; }
    }
}