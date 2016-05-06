// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Parameters for a ComputeNodeOperations.Remove request.
    /// </summary>
    public partial class NodeRemoveParameter
    {
        /// <summary>
        /// Initializes a new instance of the NodeRemoveParameter class.
        /// </summary>
        public NodeRemoveParameter() { }

        /// <summary>
        /// Initializes a new instance of the NodeRemoveParameter class.
        /// </summary>
        public NodeRemoveParameter(IList<string> nodeList, TimeSpan? resizeTimeout = default(TimeSpan?), ComputeNodeDeallocationOption? nodeDeallocationOption = default(ComputeNodeDeallocationOption?))
        {
            NodeList = nodeList;
            ResizeTimeout = resizeTimeout;
            NodeDeallocationOption = nodeDeallocationOption;
        }

        /// <summary>
        /// Sets a list containing the id of the compute nodes to be removed
        /// from the specified pool.
        /// </summary>
        [JsonProperty(PropertyName = "nodeList")]
        public IList<string> NodeList { get; set; }

        /// <summary>
        /// Sets the timeout for removal of compute nodes to the pool. The
        /// default value is 10 minutes.
        /// </summary>
        [JsonProperty(PropertyName = "resizeTimeout")]
        public TimeSpan? ResizeTimeout { get; set; }

        /// <summary>
        /// Sets when compute nodes may be removed from the pool. Possible
        /// values include: 'requeue', 'terminate', 'taskcompletion',
        /// 'retaineddata'
        /// </summary>
        [JsonProperty(PropertyName = "nodeDeallocationOption")]
        public ComputeNodeDeallocationOption? NodeDeallocationOption { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (NodeList == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "NodeList");
            }
        }
    }
}
