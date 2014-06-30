// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.WindowsAzure.Management.TrafficManager.Models
{
    /// <summary>
    /// DNS related option.
    /// </summary>
    public partial class DefinitionDnsOptions
    {
        private int _timeToLiveInSeconds;
        
        /// <summary>
        /// Required. Specifies the DNS Time-to-Live (TTL) that informs the
        /// Local DNS resolvers how long to cache DNS entries. The value is an
        /// integer from 30 through 999,999.
        /// </summary>
        public int TimeToLiveInSeconds
        {
            get { return this._timeToLiveInSeconds; }
            set { this._timeToLiveInSeconds = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DefinitionDnsOptions class.
        /// </summary>
        public DefinitionDnsOptions()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the DefinitionDnsOptions class with
        /// required arguments.
        /// </summary>
        public DefinitionDnsOptions(int timeToLiveInSeconds)
            : this()
        {
            this.TimeToLiveInSeconds = timeToLiveInSeconds;
        }
    }
}
