﻿//
// ReinstallNuGetPackageAction.cs
//
// Author:
//       Matt Ward <matt.ward@xamarin.com>
//
// Copyright (c) 2016 Xamarin Inc. (http://xamarin.com)
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Threading;
using NuGet.PackageManagement;
using NuGet.Versioning;

namespace MonoDevelop.PackageManagement
{
	internal class ReinstallNuGetPackageAction : IPackageAction
	{
		NuGetProjectContext context;
		InstallNuGetPackageAction installAction;
		UninstallNuGetPackageAction uninstallAction;

		public ReinstallNuGetPackageAction (
			IDotNetProject project,
			IMonoDevelopSolutionManager solutionManager)
		{
			context = new NuGetProjectContext ();

			CreateInstallAction (solutionManager, project);
			CreateUninstallAction (solutionManager, project);
		}

		public string PackageId { get; set; }
		public NuGetVersion Version { get; set; }

		public void Execute ()
		{
			Execute (CancellationToken.None);
		}

		public void Execute (CancellationToken cancellationToken)
		{
			using (IDisposable referenceMaintainer = CreateLocalCopyReferenceMaintainer ()) {
				using (IDisposable fileMonitor = CreateFileMonitor ()) {
					uninstallAction.PackageId = PackageId;
					uninstallAction.Execute (cancellationToken);

					installAction.PackageId = PackageId;
					installAction.Version = Version;
					installAction.LicensesMustBeAccepted = false;

					// Local copy references need to be preserved before the uninstall starts so
					// we must disable this for the install action otherwise they will not be
					// preserved.
					installAction.PreserveLocalCopyReferences = false;

					installAction.Execute (cancellationToken);
				}
			}
		}

		public bool HasPackageScriptsToRun ()
		{
			return false;
		}

		void CreateUninstallAction (IMonoDevelopSolutionManager solutionManager, IDotNetProject project)
		{
			uninstallAction = new UninstallNuGetPackageAction (
				solutionManager,
				project) {
				ForceRemove = true
			};
		}

		void CreateInstallAction (IMonoDevelopSolutionManager solutionManager, IDotNetProject project)
		{
			installAction = new InstallNuGetPackageAction (
				solutionManager.CreateSourceRepositoryProvider ().GetRepositories (),
				solutionManager,
				project,
				context
			);
		}

		LocalCopyReferenceMaintainer CreateLocalCopyReferenceMaintainer ()
		{
			return new LocalCopyReferenceMaintainer (PackageManagementServices.PackageManagementEvents);
		}

		IDisposable CreateFileMonitor ()
		{
			return new PreventPackagesConfigFileBeingRemovedOnUpdateMonitor (
				PackageManagementServices.PackageManagementEvents,
				new FileRemover ());
		}
	}
}
