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
    public partial class CreateAppRequest : CloudFoundry.CloudController.V2.Client.Data.Base.CreateAppRequest
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class CreateAppRequest
    {

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }

        [JsonProperty("space_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? SpaceGuid
        {
            get;
            set;
        }

        [JsonProperty("memory", NullValueHandling = NullValueHandling.Ignore)]
        public string Memory
        {
            get;
            set;
        }

        [JsonProperty("instances", NullValueHandling = NullValueHandling.Ignore)]
        public string Instances
        {
            get;
            set;
        }

        [JsonProperty("disk_quota", NullValueHandling = NullValueHandling.Ignore)]
        public string DiskQuota
        {
            get;
            set;
        }

        [JsonProperty("stack_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? StackGuid
        {
            get;
            set;
        }

        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State
        {
            get;
            set;
        }

        [JsonProperty("detected_start_command", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic DetectedStartCommand
        {
            get;
            set;
        }

        [JsonProperty("command", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Command
        {
            get;
            set;
        }

        [JsonProperty("buildpack", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Buildpack
        {
            get;
            set;
        }

        [JsonProperty("health_check_type", NullValueHandling = NullValueHandling.Ignore)]
        public string HealthCheckType
        {
            get;
            set;
        }

        [JsonProperty("health_check_timeout", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic HealthCheckTimeout
        {
            get;
            set;
        }

        [JsonProperty("docker_image", NullValueHandling = NullValueHandling.Ignore)]
        public string DockerImage
        {
            get;
            set;
        }

        [JsonProperty("environment_json", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic EnvironmentJson
        {
            get;
            set;
        }

        [JsonProperty("production", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Production
        {
            get;
            set;
        }

        [JsonProperty("console", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Console
        {
            get;
            set;
        }

        [JsonProperty("debug", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Debug
        {
            get;
            set;
        }
    }
}