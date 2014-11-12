/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the TerminateInstanceInAutoScalingGroup operation.
    /// Terminates the specified instance.        Optionally, the desired group size
    /// can be adjusted.        
    /// 
    ///         <note>        This call simply registers a termination request.        The
    /// termination of the instance cannot happen immediately.        </note>
    /// </summary>
    public partial class TerminateInstanceInAutoScalingGroupRequest : AmazonWebServiceRequest
    {
        private string _instanceId;
        private bool? _shouldDecrementDesiredCapacity;


        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        ///         The ID of the Amazon EC2 instance to be terminated.        
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }


        /// <summary>
        /// Sets the InstanceId property
        /// </summary>
        /// <param name="instanceId">The value to set for the InstanceId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TerminateInstanceInAutoScalingGroupRequest WithInstanceId(string instanceId)
        {
            this._instanceId = instanceId;
            return this;
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }


        /// <summary>
        /// Gets and sets the property ShouldDecrementDesiredCapacity. 
        /// <para>
        ///         Specifies whether (<i>true</i>) or not (<i>false</i>)        terminating this
        /// instance should also decrement the        size of the <a>AutoScalingGroup</a>.   
        ///     
        /// </para>
        /// </summary>
        public bool ShouldDecrementDesiredCapacity
        {
            get { return this._shouldDecrementDesiredCapacity.GetValueOrDefault(); }
            set { this._shouldDecrementDesiredCapacity = value; }
        }


        /// <summary>
        /// Sets the ShouldDecrementDesiredCapacity property
        /// </summary>
        /// <param name="shouldDecrementDesiredCapacity">The value to set for the ShouldDecrementDesiredCapacity property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TerminateInstanceInAutoScalingGroupRequest WithShouldDecrementDesiredCapacity(bool shouldDecrementDesiredCapacity)
        {
            this._shouldDecrementDesiredCapacity = shouldDecrementDesiredCapacity;
            return this;
        }

        // Check to see if ShouldDecrementDesiredCapacity property is set
        internal bool IsSetShouldDecrementDesiredCapacity()
        {
            return this._shouldDecrementDesiredCapacity.HasValue; 
        }

    }
}