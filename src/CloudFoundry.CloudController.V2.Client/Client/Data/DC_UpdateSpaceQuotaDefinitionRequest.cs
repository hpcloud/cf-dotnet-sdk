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
    public partial class UpdateSpaceQuotaDefinitionRequest : CloudFoundry.CloudController.V2.Client.Data.Base.UpdateSpaceQuotaDefinitionRequest
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class UpdateSpaceQuotaDefinitionRequest
    {

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }

        [JsonProperty("non_basic_services_allowed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NonBasicServicesAllowed
        {
            get;
            set;
        }

        [JsonProperty("total_services", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalServices
        {
            get;
            set;
        }

        [JsonProperty("total_routes", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalRoutes
        {
            get;
            set;
        }

        [JsonProperty("memory_limit", NullValueHandling = NullValueHandling.Ignore)]
        public string MemoryLimit
        {
            get;
            set;
        }

        [JsonProperty("instance_memory_limit", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceMemoryLimit
        {
            get;
            set;
        }

        [JsonProperty("organization_guid", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationGuid
        {
            get;
            set;
        }
    }
}