// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Threading;
using System.Threading.Tasks;
using NuGet.Protocol.Core.Types;

namespace NuGet.Protocol
{
    public class PackageSearchResourceV2FeedProvider : ResourceProvider
    {
        public PackageSearchResourceV2FeedProvider()
            : base(typeof(PackageSearchResource), nameof(PackageSearchResourceV2FeedProvider), NuGetResourceProviderPositions.Last)
        {
        }

        public override async Task<Tuple<bool, INuGetResource>> TryCreate(SourceRepository source,
                                                                          CancellationToken token)
        {
            PackageSearchResourceV2Feed resource = null;

            if (await source.GetFeedType(token) == FeedType.HttpV2)
            {
                var httpSourceResource = await source.GetResourceAsync<HttpSourceResource>(token);

                var serviceDocument = await source.GetResourceAsync<ODataServiceDocumentResourceV2>(token);

                //////////////////////////////////////////////////////////
                // Start - Chocolatey Specific Modification
                //////////////////////////////////////////////////////////

                if (serviceDocument != null)
                {
                    var parser = new V2FeedParser(httpSourceResource.HttpSource, serviceDocument.BaseAddress, source.PackageSource.Source);
                    var feedCapabilityResource = new LegacyFeedCapabilityResourceV2Feed(parser, serviceDocument.BaseAddress);
                    if (await feedCapabilityResource.SupportsSearchAsync(Common.NullLogger.Instance, token))
                    {
                        resource = new PackageSearchResourceV2Feed(httpSourceResource, serviceDocument.BaseAddress, source.PackageSource);
                    }
                }

                //////////////////////////////////////////////////////////
                // End - Chocolatey Specific Modification
                //////////////////////////////////////////////////////////
            }

            return new Tuple<bool, INuGetResource>(resource != null, resource);
        }
    }
}
