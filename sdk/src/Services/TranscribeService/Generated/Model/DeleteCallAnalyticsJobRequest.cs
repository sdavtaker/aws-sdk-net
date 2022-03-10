/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteCallAnalyticsJob operation.
    /// Deletes a call analytics job. To use this operation, specify the name of the job you
    /// want to delete using <code>CallAnalyticsJobName</code>.
    /// </summary>
    public partial class DeleteCallAnalyticsJobRequest : AmazonTranscribeServiceRequest
    {
        private string _callAnalyticsJobName;

        /// <summary>
        /// Gets and sets the property CallAnalyticsJobName. 
        /// <para>
        /// The name of the call analytics job you want to delete. Job names are case-sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string CallAnalyticsJobName
        {
            get { return this._callAnalyticsJobName; }
            set { this._callAnalyticsJobName = value; }
        }

        // Check to see if CallAnalyticsJobName property is set
        internal bool IsSetCallAnalyticsJobName()
        {
            return this._callAnalyticsJobName != null;
        }

    }
}