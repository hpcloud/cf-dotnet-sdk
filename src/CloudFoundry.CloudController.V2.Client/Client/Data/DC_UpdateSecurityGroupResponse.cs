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
    public partial class UpdateSecurityGroupResponse : CloudFoundry.CloudController.V2.Client.Data.Base.UpdateSecurityGroupResponse
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class UpdateSecurityGroupResponse : IResponse
    {
        public Metadata EntityMetadata
        {
            get;
            set;
        }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }

        [JsonProperty("rules", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic[] Rules
        {
            get;
            set;
        }

        [JsonProperty("running_default", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic RunningDefault
        {
            get;
            set;
        }

        [JsonProperty("staging_default", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic StagingDefault
        {
            get;
            set;
        }

        [JsonProperty("spaces_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SpacesUrl
        {
            get;
            set;
        }
    }
}