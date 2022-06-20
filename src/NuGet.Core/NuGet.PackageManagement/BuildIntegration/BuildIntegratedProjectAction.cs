// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using NuGet.Commands;
using NuGet.Frameworks;
using NuGet.Packaging.Core;
using NuGet.ProjectManagement;
using NuGet.ProjectModel;
using NuGet.Protocol.Core.Types;
using NuGet.Versioning;

namespace NuGet.PackageManagement
{
    public class BuildIntegratedProjectAction : NuGetProjectAction
    {
        /// <summary>
        /// Before the update
        /// </summary>
        public LockFile OriginalLockFile { get; }

        /// <summary>
        /// After applying the changes
        /// </summary>
        public RestoreResult RestoreResult { get; }

        /// <summary>
        /// After applying the changes
        /// </summary>
        public RestoreResultPair RestoreResultPair { get; }

        /// <summary>
        /// Sources used for package restore.
        /// </summary>
        public IReadOnlyList<SourceRepository> Sources { get; }

        /// <summary>
        /// Original user actions.
        /// </summary>
        public IReadOnlyList<NuGetProjectAction> OriginalActions { get; }

        /// <summary>
        /// The context necessary for installing a package.
        /// </summary>
        public BuildIntegratedInstallationContext InstallationContext { get; }

        public BuildIntegratedProjectAction(NuGetProject project,
            PackageIdentity packageIdentity,
            NuGetProjectActionType nuGetProjectActionType,
            LockFile originalLockFile,
            RestoreResultPair restoreResultPair,
            IReadOnlyList<SourceRepository> sources,
            IReadOnlyList<NuGetProjectAction> originalActions,
            BuildIntegratedInstallationContext installationContext)
            : this(project, packageIdentity, nuGetProjectActionType, originalLockFile, restoreResultPair, sources, originalActions, installationContext, versionRange: null)
        {
        }

        public BuildIntegratedProjectAction(NuGetProject project,
            PackageIdentity packageIdentity,
            NuGetProjectActionType nuGetProjectActionType,
            LockFile originalLockFile,
            RestoreResultPair restoreResultPair,
            IReadOnlyList<SourceRepository> sources,
            IReadOnlyList<NuGetProjectAction> originalActions,
            BuildIntegratedInstallationContext installationContext,
            VersionRange versionRange)
            : base(packageIdentity, nuGetProjectActionType, project, sourceRepository: null, versionRange)
        {
            if (packageIdentity == null)
            {
                throw new ArgumentNullException(nameof(packageIdentity));
            }

            if (originalLockFile == null)
            {
                throw new ArgumentNullException(nameof(originalLockFile));
            }

            if (restoreResultPair == null)
            {
                throw new ArgumentNullException(nameof(restoreResultPair));
            }

            if (sources == null)
            {
                throw new ArgumentNullException(nameof(sources));
            }

            if (originalActions == null)
            {
                throw new ArgumentNullException(nameof(sources));
            }

            if (installationContext == null)
            {
                throw new ArgumentNullException(nameof(sources));
            }

            OriginalLockFile = originalLockFile;
            RestoreResult = restoreResultPair.Result;
            RestoreResultPair = restoreResultPair;
            Sources = sources;
            OriginalActions = originalActions;
            InstallationContext = installationContext;
        }

        public IReadOnlyList<NuGetProjectAction> GetProjectActions()
        {
            var actions = new List<NuGetProjectAction>();

            if (RestoreResult.Success)
            {
                var added = BuildIntegratedRestoreUtility.GetAddedPackagesWithVersionRange(OriginalLockFile, RestoreResult.LockFile);
                var removed = BuildIntegratedRestoreUtility.GetAddedPackagesWithVersionRange(RestoreResult.LockFile, OriginalLockFile);

                foreach (var package in removed)
                {
                    actions.Add(CreateUninstallProjectAction(package.packageIdentity, Project, package.versionRange));
                }

                foreach (var package in added)
                {
                    actions.Add(CreateInstallProjectAction(package.packageIdentity, sourceRepository: null, project: Project, versionRange: package.versionRange));
                }
            }

            return actions;
        }
    }
}
