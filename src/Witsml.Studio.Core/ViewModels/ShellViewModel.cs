﻿//----------------------------------------------------------------------- 
// PDS.Witsml.Studio, 2016.1
//
// Copyright 2016 Petrotechnical Data Systems
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//-----------------------------------------------------------------------

using System;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using Caliburn.Micro;
using PDS.Framework;
using PDS.Witsml.Studio.Core.Runtime;

namespace PDS.Witsml.Studio.Core.ViewModels
{
    /// <summary>
    /// Manages the main application user interface
    /// </summary>
    public sealed class ShellViewModel : Conductor<IScreen>.Collection.OneActive, IShellViewModel
    {
        private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(typeof(ShellViewModel));

        /// <summary>
        /// Initializes an instance of the ShellViewModel
        /// </summary>
        [ImportingConstructor]
        public ShellViewModel(IRuntimeService runtime)
        {
            _log.Debug("Loading Shell");

            Runtime = runtime;
            DisplayName = "WITSML Studio";
            StatusBarText = "Ready.";
        }

        /// <summary>
        /// Gets the runtime service.
        /// </summary>
        /// <value>The runtime service instance.</value>
        public IRuntimeService Runtime { get; private set; }

        private string _breadcrumbText;

        /// <summary>
        /// Gets or sets the breadcrumb path for the application shell
        /// </summary>
        public string BreadcrumbText
        {
            get { return _breadcrumbText; }
            set
            {
                if (!string.Equals(_breadcrumbText, value))
                {
                    _breadcrumbText = value;
                    NotifyOfPropertyChange(() => BreadcrumbText);
                }
            }
        }

        private string _statusBarText;

        /// <summary>
        /// Gets or sets the status bar text for the application shell
        /// </summary>
        public string StatusBarText
        {
            get { return _statusBarText; }
            set
            {
                if (!string.Equals(_statusBarText, value))
                {
                    _statusBarText = value;
                    NotifyOfPropertyChange(() => StatusBarText);
                }
            }
        }

        /// <summary>
        /// Opens the current working directory.
        /// </summary>
        public void OpenWorkingDirectory()
        {
            Process.Start("explorer.exe", Environment.CurrentDirectory);
        }

        /// <summary>
        /// Exits the application.
        /// </summary>
        public void Exit()
        {
            Application.Current.Shutdown();
        }

        /// <summary>
        /// Shows the About dialog for the application.
        /// </summary>
        public void About()
        {
            var version = Application.Current.GetType().GetAssemblyVersion();
            Runtime.ShowInfo("WITSML Studio v" + version);
        }

        /// <summary>
        /// Sets the breadcrumb text.
        /// </summary>
        /// <param name="values">The values.</param>
        public void SetBreadcrumb(params object[] values)
        {
            BreadcrumbText = string.Join(" / ", values);
        }

        /// <summary>
        /// Loads the plug-ins.
        /// </summary>
        internal void LoadPlugins()
        {
            Items.AddRange(Runtime.Container
                .ResolveAll<IPluginViewModel>()
                .OrderBy(x => x.DisplayOrder));

            if (_log.IsDebugEnabled)
            {
                _log.DebugFormat("{0}{1}{2}", "Plugins Loaded:", Environment.NewLine, string.Join(Environment.NewLine, Items.Select(x => x.DisplayName)));
            }

            ActivateItem(Items.FirstOrDefault());
        }

        /// <summary>
        /// Called the first time the page's LayoutUpdated event fires after it is navigated to.
        /// </summary>
        /// <param name="view">The view attached to the current view model.</param>
        protected override void OnViewReady(object view)
        {
            base.OnViewReady(view);
            LoadPlugins();
        }

        /// <summary>
        /// Called by a subclass when an activation needs processing.
        /// </summary>
        /// <param name="item">The item on which activation was attempted.</param>
        /// <param name="success">if set to <c>true</c> activation was successful.</param>
        protected override void OnActivationProcessed(IScreen item, bool success)
        {
            base.OnActivationProcessed(item, success);

            if (item != null && success)
            {
                BreadcrumbText = item.DisplayName;
            }
        }
    }
}
