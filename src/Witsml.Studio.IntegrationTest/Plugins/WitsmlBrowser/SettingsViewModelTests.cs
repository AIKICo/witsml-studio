﻿//----------------------------------------------------------------------- 
// PDS.Witsml.Studio, 2017.1
//
// Copyright 2017 Petrotechnical Data Systems
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

using Energistics.DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PDS.Witsml.Studio.Core.Connections;
using PDS.Witsml.Studio.Plugins.WitsmlBrowser.ViewModels.Request;
using PDS.Witsml.Studio.Core.Runtime;
using PDS.Witsml.Studio.Core.ViewModels;

namespace PDS.Witsml.Studio.Plugins.WitsmlBrowser
{
    [TestClass]
    public class SettingsViewModelTests
    {
        private static string _validWitsmlUri = "http://localhost/Witsml.Web/WitsmlStore.svc";

        private BootstrapperHarness _bootstrapper;
        private TestRuntimeService _runtime;
        private SettingsViewModel _settingsViewModel;

        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void TestSetUp()
        {
            _bootstrapper = new BootstrapperHarness();
            _runtime = new TestRuntimeService(_bootstrapper.Container);
            _runtime.Shell = new ShellViewModel(_runtime);
            _settingsViewModel = new SettingsViewModel(_runtime);

            if (TestContext.Properties.Contains("WitsmlStoreUrl"))
                _validWitsmlUri = TestContext.Properties["WitsmlStoreUrl"].ToString();
        }

        [TestMethod]
        public void SettingsViewModel_GetVersions_Can_Get_Supported_Versions()
        {
            WITSMLWebServiceConnection proxy = new WITSMLWebServiceConnection(_validWitsmlUri, WMLSVersion.WITSML141);
            Connection connection = new Connection() { Uri = _validWitsmlUri };

            var versions = _settingsViewModel.GetVersions(proxy, connection);
            Assert.IsTrue(!string.IsNullOrEmpty(versions));
        }
    }
}
