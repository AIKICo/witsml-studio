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

using Caliburn.Micro;
using PDS.Witsml.Studio.Core.Connections;

namespace PDS.Witsml.Studio.Plugins.WitsmlBrowser.Models
{
    /// <summary>
    /// Encapsulates Witsml settings and options sent to the store.
    /// </summary>
    /// <seealso cref="Caliburn.Micro.PropertyChangedBase" />
    public class WitsmlSettings : PropertyChangedBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WitsmlSettings"/> class.
        /// </summary>
        public WitsmlSettings()
        {
            Connection = new Connection();
            StoreFunction = Functions.GetFromStore;
            OutputPath = "./Data/Results";
            TruncateSize = 1000000; // 1M char
        }

        private Connection _connection;

        /// <summary>
        /// Gets or sets the connection.
        /// </summary>
        /// <value>
        /// The connection.
        /// </value>
        public Connection Connection
        {
            get { return _connection; }
            set
            {
                if (!ReferenceEquals(_connection, value))
                {
                    _connection = value;
                    NotifyOfPropertyChange(() => Connection);
                }
            }
        }

        private OptionsIn.ReturnElements _returnElementType;

        /// <summary>
        /// Gets or sets the type of the return element.
        /// </summary>
        /// <value>
        /// The type of the return element.
        /// </value>
        public OptionsIn.ReturnElements ReturnElementType
        {
            get { return _returnElementType; }
            set
            {
                if (_returnElementType != value)
                {
                    _returnElementType = value;
                    NotifyOfPropertyChange(() => ReturnElementType);
                }
            }
        }

        private bool _isRequestObjectSelectionCapability;

        /// <summary>
        /// Gets or sets a value indicating whether to request object selection capability.
        /// </summary>
        /// <value>
        /// <c>true</c> if to request object selection capability; otherwise, <c>false</c>.
        /// </value>
        public bool IsRequestObjectSelectionCapability
        {
            get { return _isRequestObjectSelectionCapability; }
            set
            {
                if (_isRequestObjectSelectionCapability != value)
                {
                    _isRequestObjectSelectionCapability = value;
                    OnRequestObjectSelectionCapabilityChanged();
                    NotifyOfPropertyChange(() => IsRequestObjectSelectionCapability);
                }
            }
        }

        private bool _isRequestPrivateGroupOnly;

        /// <summary>
        /// Gets or sets a value indicating whether to request private group only.
        /// </summary>
        /// <value>
        /// <c>true</c> if to request private group only; otherwise, <c>false</c>.
        /// </value>
        public bool IsRequestPrivateGroupOnly
        {
            get { return _isRequestPrivateGroupOnly; }
            set
            {
                if (_isRequestPrivateGroupOnly != value)
                {
                    _isRequestPrivateGroupOnly = value;
                    NotifyOfPropertyChange(() => IsRequestPrivateGroupOnly);
                }
            }
        }

        private bool _isSaveQueryResponse;

        /// <summary>
        /// Gets or sets a value indicating whether to save query response.
        /// </summary>
        /// <value>
        /// <c>true</c> if to save query response; otherwise, <c>false</c>.
        /// </value>
        public bool IsSaveQueryResponse
        {
            get { return _isSaveQueryResponse; }
            set
            {
                if (_isSaveQueryResponse != value)
                {
                    _isSaveQueryResponse = value;
                    NotifyOfPropertyChange(() => IsSaveQueryResponse);
                }
            }
        }

        private bool _isSplitResults;

        /// <summary>
        /// Gets or sets a value indicating whether to split results.
        /// </summary>
        /// <value>
        /// <c>true</c> if to split results; otherwise, <c>false</c>.
        /// </value>
        public bool IsSplitResults
        {
            get { return _isSplitResults; }
            set
            {
                if (_isSplitResults != value)
                {
                    _isSplitResults = value;
                    NotifyOfPropertyChange(() => IsSplitResults);
                }
            }
        }

        private string _outputPath;

        /// <summary>
        /// Gets or sets the output path.
        /// </summary>
        /// <value>
        /// The output path.
        /// </value>
        public string OutputPath
        {
            get { return _outputPath; }
            set
            {
                if (_outputPath != value)
                {
                    _outputPath = value;
                    NotifyOfPropertyChange(() => OutputPath);
                }
            }
        }

        private string _witsmlVersion;

        /// <summary>
        /// Gets or sets the witsml version.
        /// </summary>
        /// <value>
        /// The witsml version.
        /// </value>
        public string WitsmlVersion
        {
            get { return _witsmlVersion; }
            set
            {
                if (_witsmlVersion != value)
                {
                    _witsmlVersion = value;
                    NotifyOfPropertyChange(() => WitsmlVersion);
                }
            }
        }

        private string _extraOptionsIn;

        /// <summary>
        /// Gets or sets the extra options in.
        /// </summary>
        /// <value>
        /// The extra options in.
        /// </value>
        public string ExtraOptionsIn
        {
            get { return _extraOptionsIn; }
            set
            {
                if (_extraOptionsIn != value)
                {
                    _extraOptionsIn = value;
                    NotifyOfPropertyChange(() => ExtraOptionsIn);
                }
            }
        }

        private int? _maxDataRows;

        /// <summary>
        /// Gets or sets the maximum number of return data rows.
        /// </summary>
        /// <value>
        /// The maximum number of return data rows.
        /// </value>
        public int? MaxDataRows
        {
            get { return _maxDataRows; }
            set
            {
                if (_maxDataRows != value)
                {
                    _maxDataRows = value;
                    NotifyOfPropertyChange(() => MaxDataRows);
                }
            }
        }

        private int? _requestLatestValues;

        /// <summary>
        /// Gets or sets the number of latest values for the request (growing object only).
        /// </summary>
        /// <value>
        /// The the number of latest values for the request.
        /// </value>
        public int? RequestLatestValues
        {
            get { return _requestLatestValues; }
            set
            {
                if (_requestLatestValues != value)
                {
                    _requestLatestValues = value;
                    NotifyOfPropertyChange(() => _requestLatestValues);
                }
            }
        }

        private bool _retrievePartialResults;

        /// <summary>
        /// Gets or sets a value indicating whether to retrieve partial results automatically.
        /// </summary>
        /// <value>
        /// <c>true</c> if to retrieve partial resultsautomatically; otherwise, <c>false</c>.
        /// </value>
        public bool RetrievePartialResults
        {
            get { return _retrievePartialResults; }
            set
            {
                if (_retrievePartialResults != value)
                {
                    _retrievePartialResults = value;
                    NotifyOfPropertyChange(() => RetrievePartialResults);
                }
            }
        }

        private bool _keepGridData;

        /// <summary>
        /// Gets or sets a value indicating whether to keep grid data when querying partial results.
        /// </summary>
        /// <value>
        ///   <c>true</c> if to keep grid data when querying partial results; otherwise, <c>false</c>.
        /// </value>
        public bool KeepGridData
        {
            get { return _keepGridData; }
            set
            {
                if (_keepGridData != value)
                {
                    _keepGridData = value;
                    NotifyOfPropertyChange(() => KeepGridData);
                }
            }
        }

        private int _truncateSize;

        /// <summary>
        /// Gets or sets the size of the truncate.
        /// </summary>
        /// <value>
        /// The size of the truncate.
        /// </value>
        public int TruncateSize
        {
            get { return _truncateSize; }
            set
            {
                if (_truncateSize != value)
                {
                    _truncateSize = value;
                    NotifyOfPropertyChange(() => TruncateSize);
                }
            }
        }

        private short? _errorCode;

        /// <summary>
        /// Gets or sets the error code.
        /// </summary>
        /// <value>
        /// The error code.
        /// </value>
        public short? ErrorCode
        {
            get { return _errorCode; }
            set
            {
                if (_errorCode != value)
                {
                    _errorCode = value;
                    NotifyOfPropertyChange(() => ErrorCode);
                }
            }
        }

        private bool _cascadedDelete;

        /// <summary>
        /// Gets or sets a value indicating whether CascadedDelete is enabled.
        /// </summary>
        /// <value>
        ///   <c>true</c> if CascadedDelete is enabled; otherwise, <c>false</c>.
        /// </value>
        public bool CascadedDelete
        {
            get { return _cascadedDelete; }
            set
            {
                if (_cascadedDelete != value)
                {
                    _cascadedDelete = value;
                    NotifyOfPropertyChange(() => CascadedDelete);
                }
            }
        }

        private Functions _storeFunction;

        /// <summary>
        /// Gets or sets the store function.
        /// </summary>
        /// <value>
        /// The store function.
        /// </value>
        public Functions StoreFunction
        {
            get { return _storeFunction; }
            set
            {
                if (_storeFunction != value)
                {
                    _storeFunction = value;
                    NotifyOfPropertyChange(() => StoreFunction);
                    NotifyOfPropertyChange(() => IsGetFromStore);
                    NotifyOfPropertyChange(() => IsDeleteFromStore);
                }
            }
        }

        /// <summary>
        /// Gets a value indicating whether StoreFunction equals GetFromStore.
        /// </summary>
        /// <value>
        /// <c>true</c> if StoreFunction equals GetFromStore; otherwise, <c>false</c>.
        /// </value>
        public bool IsGetFromStore => StoreFunction == Functions.GetFromStore;

        /// <summary>
        /// Gets a value indicating whether StoreFunction equals DeleteFromStore.
        /// </summary>
        /// <value>
        /// <c>true</c> if StoreFunction equals DeleteFromStore; otherwise, <c>false</c>.
        /// </value>
        public bool IsDeleteFromStore => StoreFunction == Functions.DeleteFromStore;

        /// <summary>
        /// Called when RequestObjectSelectionCapability has changed.
        /// </summary>
        private void OnRequestObjectSelectionCapabilityChanged()
        {
            ReturnElementType = IsRequestObjectSelectionCapability ? null : OptionsIn.ReturnElements.All;

            if (IsRequestObjectSelectionCapability && IsRequestPrivateGroupOnly)
            {
                IsRequestPrivateGroupOnly = false;
            }
        }
    }
}
