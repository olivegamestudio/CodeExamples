using System;
using System.Collections.Generic;
using System.Threading;
using NuGet.Common;
using NuGet.Configuration;
using NuGet.Protocol;
using NuGet.Protocol.Core.Types;

namespace NuGetLibraryVersions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = args[0];
            string feed = args[1];
            string username = args[2];
            string password = args[3];

            List<Lazy<INuGetResourceProvider>> providers = new();
            providers.AddRange(Repository.Provider.GetCoreV3());  // Add v3 API support

            PackageSource packageSource = new(feed);
            packageSource.Credentials = new PackageSourceCredential(feed, username, password, true);

            SourceRepository sourceRepository = new(packageSource, providers);

            var packageMetadataResource = sourceRepository.GetResourceAsync<PackageMetadataResource>();
            packageMetadataResource.Wait();

            var logger = new NullLogger();
            var searchMetadata = packageMetadataResource.Result.GetMetadataAsync(name, true, true, new NullSourceCacheContext(), logger, CancellationToken.None);
            searchMetadata.Wait();

            foreach (var entry in searchMetadata.Result)
            {
                var version = entry.Identity.Version;
                Console.WriteLine(version);
            }
        }
    }
}
