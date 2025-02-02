// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace NuGet.Protocol.Core.Types
{
    public enum SearchOrderBy
    {
        /// <summary>
        /// Order the resulting packages by package ID.
        /// </summary>
        Id,

        //////////////////////////////////////////////////////////
        // Start - Chocolatey Specific Modification
        //////////////////////////////////////////////////////////

        /// <summary>
        /// Order the resulting packages by number of donwnloads.
        /// </summary>
        DownloadCount

        //////////////////////////////////////////////////////////
        // End - Chocolatey Specific Modification
        //////////////////////////////////////////////////////////
    }
}
