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
 * Do not modify this file. This file is generated from the lookoutequipment-2020-12-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// Entity that comprises aggregated information on sensors having insufficient data.
    /// </summary>
    public partial class InsufficientSensorData
    {
        private MissingCompleteSensorData _missingCompleteSensorData;
        private SensorsWithShortDateRange _sensorsWithShortDateRange;

        /// <summary>
        /// Gets and sets the property MissingCompleteSensorData. 
        /// <para>
        ///  Parameter that describes the total number of sensors that have data completely missing
        /// for it. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MissingCompleteSensorData MissingCompleteSensorData
        {
            get { return this._missingCompleteSensorData; }
            set { this._missingCompleteSensorData = value; }
        }

        // Check to see if MissingCompleteSensorData property is set
        internal bool IsSetMissingCompleteSensorData()
        {
            return this._missingCompleteSensorData != null;
        }

        /// <summary>
        /// Gets and sets the property SensorsWithShortDateRange. 
        /// <para>
        ///  Parameter that describes the total number of sensors that have a short date range
        /// of less than 90 days of data overall. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SensorsWithShortDateRange SensorsWithShortDateRange
        {
            get { return this._sensorsWithShortDateRange; }
            set { this._sensorsWithShortDateRange = value; }
        }

        // Check to see if SensorsWithShortDateRange property is set
        internal bool IsSetSensorsWithShortDateRange()
        {
            return this._sensorsWithShortDateRange != null;
        }

    }
}