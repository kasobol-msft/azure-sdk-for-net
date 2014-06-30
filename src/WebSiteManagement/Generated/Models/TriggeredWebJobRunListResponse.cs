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
using System.Collections.Generic;
using System.Linq;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.WebSitesExtensions.Models;

namespace Microsoft.WindowsAzure.WebSitesExtensions.Models
{
    /// <summary>
    /// The triggered WebJob run list operation response.
    /// </summary>
    public partial class TriggeredWebJobRunListResponse : OperationResponse, IEnumerable<TriggeredWebJobRun>
    {
        private IList<TriggeredWebJobRun> _triggeredWebJobRuns;
        
        /// <summary>
        /// Optional. The list of job runs.
        /// </summary>
        public IList<TriggeredWebJobRun> TriggeredWebJobRuns
        {
            get { return this._triggeredWebJobRuns; }
            set { this._triggeredWebJobRuns = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the TriggeredWebJobRunListResponse
        /// class.
        /// </summary>
        public TriggeredWebJobRunListResponse()
        {
            this.TriggeredWebJobRuns = new List<TriggeredWebJobRun>();
            this.JobRuns = new List<WebJobRun>();
        }
        
        /// <summary>
        /// Gets the sequence of TriggeredWebJobRuns.
        /// </summary>
        public IEnumerator<TriggeredWebJobRun> GetEnumerator()
        {
            return this.TriggeredWebJobRuns.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of TriggeredWebJobRuns.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
