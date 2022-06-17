// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;

namespace NuGet.Options
{
    /// <summary>
    /// The Tools>Options page for "Package Source Mapping".
    /// </summary>
    [Guid("F175964E-89F5-4521-8FE2-C10C07BB968C")]
    public class PackageSourceMappingOptionsPage : UIElementDialogPage
    {
        private Lazy<PackageSourceMappingOptionsControl> _packageSourceMappingOptionsControl;

        /// <summary>
        /// Gets the Windows Presentation Foundation (WPF) child element to be hosted inside the Options dialog page.
        /// </summary>
        /// <returns>The WPF child element.</returns>
        protected override UIElement Child
        {
            get
            {
                return _packageSourceMappingOptionsControl.Value;
            }
        }

        public PackageSourceMappingOptionsPage()
        {
            _packageSourceMappingOptionsControl = new Lazy<PackageSourceMappingOptionsControl>(() => new PackageSourceMappingOptionsControl());
        }

        /// <summary>
        /// This occurs when the User selecting 'Ok' and right before the dialog page UI closes entirely.
        /// This override handles the case when the user types inside an editable combobox and 
        /// immediately hits enter causing the window to close without firing the combobox LostFocus event.
        /// </summary>
        /// <param name="e">Event arguments.</param>
        ///


        protected override void OnApply(PageApplyEventArgs e)
        {
            base.OnApply(e); // Saves the user's changes.
        }


        /// <summary>
        /// This method is called when VS wants to activate this page.
        /// ie. when the user opens the tools options page.
        /// </summary>
        /// <param name="e">Cancellation event arguments.</param>
        protected override void OnActivate(CancelEventArgs e)
        {
            // The UI caches the settings even though the tools options page is closed.
            // This load call ensures we display data that was saved. This is to handle
            // the case when the user hits the cancel button and reloads the page.
            LoadSettingsFromStorage();

            base.OnActivate(e);
        }

        protected override void OnClosed(EventArgs e)
        {
            _packageSourceMappingOptionsControl.ClearSettings();
            base.OnClosed(e);
        }
    }
}
