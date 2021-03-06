// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.LabServices.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents the environments details
    /// </summary>
    public partial class GetEnvironmentResponse
    {
        /// <summary>
        /// Initializes a new instance of the GetEnvironmentResponse class.
        /// </summary>
        public GetEnvironmentResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GetEnvironmentResponse class.
        /// </summary>
        /// <param name="environment">Details of the environment</param>
        public GetEnvironmentResponse(EnvironmentDetails environment = default(EnvironmentDetails))
        {
            Environment = environment;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets details of the environment
        /// </summary>
        [JsonProperty(PropertyName = "environment")]
        public EnvironmentDetails Environment { get; private set; }

    }
}
