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
    public partial class CreateSecurityGroupRequest : CloudFoundry.CloudController.V2.Client.Data.Base.CreateSecurityGroupRequest
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class CreateSecurityGroupRequest
    {

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }

        [JsonProperty("rules", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic>[] Rules
        {
            get;
            set;
        }

        [JsonProperty("space_guids", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic SpaceGuids
        {
            get;
            set;
        }
    }
}