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
    /// Container for the parameters to the CreateOrUpdateTags operation.
    /// Creates new tags or updates existing tags for an Auto Scaling group. 
    ///       
    /// 
    ///         <note>            A tag's definition is composed of a resource ID, resource
    /// type, key and value, and the propagate flag.             Value and the propagate flag
    /// are optional parameters. See the Request Parameters for more information.        
    ///            </note>        
    /// <para>
    /// For information on creating tags for your Auto Scaling group, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/ASTagging.html">Tag
    /// Your Auto Scaling Groups and Amazon EC2 Instances</a>.
    /// </para>
    /// </summary>
    public partial class CreateOrUpdateTagsRequest : AmazonWebServiceRequest
    {
        private List<Tag> _tags = new List<Tag>();


        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///             The tag to be created or updated. Each tag should be defined by its resource
        /// type, resource ID, key, value,             and a propagate flag. The resource type
        /// and resource ID identify the type and name of resource for which the             tag
        /// is created. Currently, <code>auto-scaling-group</code> is the only supported resource
        /// type. The valid             value for the resource ID is <i>groupname</i>.       
        /// 
        /// </para>
        ///                         
        /// <para>
        /// The <code>PropagateAtLaunch</code> flag defines whether the new tag will be applied
        /// to instances launched by             the Auto Scaling group. Valid values are <code>true</code>
        /// or <code>false</code>. However, instances that are already             running will
        /// not get the new or updated tag. Likewise, when you modify a tag, the updated version
        /// will be             applied only to new instances launched by the Auto Scaling group
        /// after the change. Running instances that had             the previous version of the
        /// tag will continue to have the older tag.         
        /// </para>
        ///         
        /// <para>
        /// When you create a tag and a tag of the same name already exists, the operation overwrites
        /// the previous tag             definition, but you will not get an error message.  
        ///      
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        /// <summary>
        /// Sets the Tags property
        /// </summary>
        /// <param name="tags">The values to add to the Tags collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateOrUpdateTagsRequest WithTags(params Tag[] tags)
        {
            foreach (var element in tags)
            {
                this._tags.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the Tags property
        /// </summary>
        /// <param name="tags">The values to add to the Tags collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateOrUpdateTagsRequest WithTags(IEnumerable<Tag> tags)
        {
            foreach (var element in tags)
            {
                this._tags.Add(element);
            }
            return this;
        }
        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}