// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.Extensibility
{
    using WixToolset.Data;
    using WixToolset.Extensibility.Data;

    public class BaseBurnBackendExtension : IBurnBackendExtension
    {
        public virtual void PostBackendBind(IBindResult result)
        {
        }

        public virtual void PreBackendBind(IBindContext context)
        {
        }

        public virtual IResolveFileResult ResolveRelatedFile(string source, string relatedSource, string type, SourceLineNumber sourceLineNumbers, BindStage bindStage)
        {
            return null;
        }

        public virtual string ResolveUrl(string url, string fallbackUrl, string packageId, string payloadId, string fileName)
        {
            return null;
        }
    }
}