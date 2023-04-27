// Copyright (c) 2022-Present Chocolatey Software, Inc.
// Copyright (c) 2015-2022 .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'void AnalyzeResult<TItem>.Combine(AnalyzeResult<TItem> result)', validate parameter 'result' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.DependencyResolver.AnalyzeResult`1.Combine(NuGet.DependencyResolver.AnalyzeResult`1)")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'void GraphOperations.Dump<TItem>(GraphNode<TItem> root, Action<string> write)', validate parameter 'root' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.DependencyResolver.GraphOperations.Dump``1(NuGet.DependencyResolver.GraphNode{``0},System.Action{System.String})")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'string GraphOperations.GetId<TItem>(GraphNode<TItem> node)', validate parameter 'node' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.DependencyResolver.GraphOperations.GetId``1(NuGet.DependencyResolver.GraphNode{``0})~System.String")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'NuGetVersion GraphOperations.GetVersionOrDefault<TItem>(GraphNode<TItem> node)', validate parameter 'node' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.DependencyResolver.GraphOperations.GetVersionOrDefault``1(NuGet.DependencyResolver.GraphNode{``0})~NuGet.Versioning.NuGetVersion")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'VersionRange GraphOperations.GetVersionRange<TItem>(GraphNode<TItem> node)', validate parameter 'node' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.DependencyResolver.GraphOperations.GetVersionRange``1(NuGet.DependencyResolver.GraphNode{``0})~NuGet.Versioning.VersionRange")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'bool GraphOperations.IsPackage<TItem>(GraphNode<TItem> node)', validate parameter 'node' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.DependencyResolver.GraphOperations.IsPackage``1(NuGet.DependencyResolver.GraphNode{``0})~System.Boolean")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'GraphNode<TItem> GraphOperations.Path<TItem>(GraphNode<TItem> node, params string[] path)', validate parameter 'node' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.DependencyResolver.GraphOperations.Path``1(NuGet.DependencyResolver.GraphNode{``0},System.String[])~NuGet.DependencyResolver.GraphNode{``0}")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'void GraphOperations.ReleaseDowngradesDictionary(Dictionary<GraphNode<RemoteResolveResult>, GraphNode<RemoteResolveResult>> dictionary)', validate parameter 'dictionary' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.DependencyResolver.GraphOperations.ReleaseDowngradesDictionary(System.Collections.Generic.Dictionary{NuGet.DependencyResolver.GraphNode{NuGet.DependencyResolver.RemoteResolveResult},NuGet.DependencyResolver.GraphNode{NuGet.DependencyResolver.RemoteResolveResult}})")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'LibraryDependency PackagingUtility.GetLibraryDependencyFromNuspec(PackageDependency dependency)', validate parameter 'dependency' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.DependencyResolver.PackagingUtility.GetLibraryDependencyFromNuspec(NuGet.Packaging.Core.PackageDependency)~NuGet.LibraryModel.LibraryDependency")]
[assembly: SuppressMessage("Build", "CA1822:Member IsDependencyValidForGraph does not access instance data and can be marked as static (Shared in VisualBasic)", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.DependencyResolver.RemoteDependencyWalker.IsDependencyValidForGraph(NuGet.LibraryModel.LibraryDependency)~System.Boolean")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'bool RemoteDependencyWalker.IsGreaterThanOrEqualTo(VersionRange nearVersion, VersionRange farVersion)', validate parameter 'farVersion' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.DependencyResolver.RemoteDependencyWalker.IsGreaterThanOrEqualTo(NuGet.Versioning.VersionRange,NuGet.Versioning.VersionRange)~System.Boolean")]
//////////////////////////////////////////////////////////
// Start - Chocolatey Specific Modification
//////////////////////////////////////////////////////////
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'Task<GraphNode<RemoteResolveResult>> RemoteDependencyWalker.WalkAsync(LibraryRange library, NuGetFramework framework, string runtimeIdentifier, RuntimeGraph runtimeGraph, bool recursive)', validate parameter 'library' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.DependencyResolver.RemoteDependencyWalker.WalkAsync(NuGet.LibraryModel.LibraryRange,Chocolatey.NuGet.Frameworks.NuGetFramework,System.String,NuGet.RuntimeModel.RuntimeGraph,System.Boolean)~System.Threading.Tasks.Task{NuGet.DependencyResolver.GraphNode{NuGet.DependencyResolver.RemoteResolveResult}}")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'Task<RemoteMatch> ResolverUtility.FindLibraryByVersionAsync(LibraryRange libraryRange, NuGetFramework framework, IEnumerable<IRemoteDependencyProvider> providers, SourceCacheContext cacheContext, ILogger logger, CancellationToken token)', validate parameter 'libraryRange' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.DependencyResolver.ResolverUtility.FindLibraryByVersionAsync(NuGet.LibraryModel.LibraryRange,Chocolatey.NuGet.Frameworks.NuGetFramework,System.Collections.Generic.IEnumerable{NuGet.DependencyResolver.IRemoteDependencyProvider},NuGet.Protocol.Core.Types.SourceCacheContext,NuGet.Common.ILogger,System.Threading.CancellationToken)~System.Threading.Tasks.Task{NuGet.DependencyResolver.RemoteMatch}")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'Task<GraphItem<RemoteResolveResult>> ResolverUtility.FindLibraryCachedAsync(ConcurrentDictionary<LibraryRangeCacheKey, Task<GraphItem<RemoteResolveResult>>> cache, LibraryRange libraryRange, NuGetFramework framework, string runtimeIdentifier, RemoteWalkContext context, CancellationToken cancellationToken)', validate parameter 'cache' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.DependencyResolver.ResolverUtility.FindLibraryCachedAsync(System.Collections.Concurrent.ConcurrentDictionary{NuGet.DependencyResolver.LibraryRangeCacheKey,System.Threading.Tasks.Task{NuGet.DependencyResolver.GraphItem{NuGet.DependencyResolver.RemoteResolveResult}}},NuGet.LibraryModel.LibraryRangeChocolatey.NuGetFramework,System.String,NuGet.DependencyResolver.RemoteWalkContext,System.Threading.CancellationToken)~System.Threading.Tasks.Task{NuGet.DependencyResolver.GraphItem{NuGet.DependencyResolver.RemoteResolveResult}}")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'Task<GraphItem<RemoteResolveResult>> ResolverUtility.FindLibraryEntryAsync(LibraryRange libraryRange, NuGetFramework framework, string runtimeIdentifier, RemoteWalkContext context, CancellationToken cancellationToken)', validate parameter 'context' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.DependencyResolver.ResolverUtility.FindLibraryEntryAsync(NuGet.LibraryModel.LibraryRange,Chocolatey.NuGet.Frameworks.NuGetFramework,System.String,NuGet.DependencyResolver.RemoteWalkContext,System.Threading.CancellationToken)~System.Threading.Tasks.Task{NuGet.DependencyResolver.GraphItem{NuGet.DependencyResolver.RemoteResolveResult}}")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'Task<RemoteMatch> ResolverUtility.FindLibraryMatchAsync(LibraryRange libraryRange, NuGetFramework framework, string runtimeIdentifier, IEnumerable<IRemoteDependencyProvider> remoteProviders, IEnumerable<IRemoteDependencyProvider> localProviders, IEnumerable<IDependencyProvider> projectProviders, IDictionary<LockFileCacheKey, IList<LibraryIdentity>> lockFileLibraries, SourceCacheContext cacheContext, ILogger logger, CancellationToken cancellationToken)', validate parameter 'libraryRange' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.DependencyResolver.ResolverUtility.FindLibraryMatchAsync(NuGet.LibraryModel.LibraryRange,Chocolatey.NuGet.Frameworks.NuGetFramework,System.String,System.Collections.Generic.IEnumerable{NuGet.DependencyResolver.IRemoteDependencyProvider},System.Collections.Generic.IEnumerable{NuGet.DependencyResolver.IRemoteDependencyProvider},System.Collections.Generic.IEnumerable{NuGet.DependencyResolver.IDependencyProvider},System.Collections.Generic.IDictionary{NuGet.DependencyResolver.LockFileCacheKey,System.Collections.Generic.IList{NuGet.LibraryModel.LibraryIdentity}},NuGet.Protocol.Core.Types.SourceCacheContext,NuGet.Common.ILogger,System.Threading.CancellationToken)~System.Threading.Tasks.Task{NuGet.DependencyResolver.RemoteMatch}")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'Task<RemoteMatch> ResolverUtility.FindProjectMatchAsync(LibraryRange libraryRange, NuGetFramework framework, IEnumerable<IDependencyProvider> projectProviders, CancellationToken cancellationToken)', validate parameter 'projectProviders' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.DependencyResolver.ResolverUtility.FindProjectMatchAsync(NuGet.LibraryModel.LibraryRange,Chocolatey.NuGet.Frameworks.NuGetFramework,System.Collections.Generic.IEnumerable{NuGet.DependencyResolver.IDependencyProvider},System.Threading.CancellationToken)~System.Threading.Tasks.Task{NuGet.DependencyResolver.RemoteMatch}")]
[assembly: SuppressMessage("Build", "CA1801:Parameter cancellationToken of method FindProjectMatchAsync is never used. Remove the parameter or use it in the method body.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.DependencyResolver.ResolverUtility.FindProjectMatchAsync(NuGet.LibraryModel.LibraryRange,Chocolatey.NuGet.Frameworks.NuGetFramework,System.Collections.Generic.IEnumerable{NuGet.DependencyResolver.IDependencyProvider},System.Threading.CancellationToken)~System.Threading.Tasks.Task{NuGet.DependencyResolver.RemoteMatch}")]
//////////////////////////////////////////////////////////
// End - Chocolatey Specific Modification
//////////////////////////////////////////////////////////
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'IEnumerable<GraphItem<TItem>> Tracker<TItem>.GetDisputes(GraphItem<TItem> item)', validate parameter 'item' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.DependencyResolver.Tracker`1.GetDisputes(NuGet.DependencyResolver.GraphItem{`0})~System.Collections.Generic.IEnumerable{NuGet.DependencyResolver.GraphItem{`0}}")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'bool Tracker<TItem>.IsAmbiguous(GraphItem<TItem> item)', validate parameter 'item' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.DependencyResolver.Tracker`1.IsAmbiguous(NuGet.DependencyResolver.GraphItem{`0})~System.Boolean")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'bool Tracker<TItem>.IsBestVersion(GraphItem<TItem> item)', validate parameter 'item' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.DependencyResolver.Tracker`1.IsBestVersion(NuGet.DependencyResolver.GraphItem{`0})~System.Boolean")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'bool Tracker<TItem>.IsDisputed(GraphItem<TItem> item)', validate parameter 'item' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.DependencyResolver.Tracker`1.IsDisputed(NuGet.DependencyResolver.GraphItem{`0})~System.Boolean")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'void Tracker<TItem>.MarkAmbiguous(GraphItem<TItem> item)', validate parameter 'item' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.DependencyResolver.Tracker`1.MarkAmbiguous(NuGet.DependencyResolver.GraphItem{`0})")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'void Tracker<TItem>.Track(GraphItem<TItem> item)', validate parameter 'item' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.DependencyResolver.Tracker`1.Track(NuGet.DependencyResolver.GraphItem{`0})")]
[assembly: SuppressMessage("Build", "CA2227:Change 'InnerNodes' to be read-only by removing the property setter.", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.DependencyResolver.GraphNode`1.InnerNodes")]
[assembly: SuppressMessage("Usage", "CA2227:Collection properties should be read only", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.DependencyResolver.RemoteResolveResult.Dependencies")]
