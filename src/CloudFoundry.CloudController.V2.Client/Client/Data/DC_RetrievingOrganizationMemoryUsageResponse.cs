//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

//
// This source code was auto-generated by cf-sdk-builder
//

using CloudFoundry.CloudController.V2.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class RetrievingOrganizationMemoryUsageResponse : CloudFoundry.CloudController.V2.Client.Data.Base.RetrievingOrganizationMemoryUsageResponse
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class RetrievingOrganizationMemoryUsageResponse : IResponse
    {
        public Metadata EntityMetadata
        {
            get;
            set;
        }

        [JsonProperty("memory_usage_in_mb", NullValueHandling = NullValueHandling.Ignore)]
        public int? MemoryUsageInMb
        {
            get;
            set;
        }
    }
}