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

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using CloudFoundry.CloudController.V2.Interfaces;

namespace CloudFoundry.CloudController.V2.Client.Data
{
public class UpdateProcessRequest
{



    [JsonProperty("name", NullValueHandling=NullValueHandling.Ignore)]
    public string Name
    {
    get;
    set;
    }

    [JsonProperty("memory", NullValueHandling=NullValueHandling.Ignore)]
    public int? Memory
    {
    get;
    set;
    }

    [JsonProperty("instances", NullValueHandling=NullValueHandling.Ignore)]
    public int? Instances
    {
    get;
    set;
    }

    [JsonProperty("disk_quota", NullValueHandling=NullValueHandling.Ignore)]
    public int? DiskQuota
    {
    get;
    set;
    }

    [JsonProperty("space_guid", NullValueHandling=NullValueHandling.Ignore)]
    public Guid? SpaceGuid
    {
    get;
    set;
    }

    [JsonProperty("stack_guid", NullValueHandling=NullValueHandling.Ignore)]
    public Guid? StackGuid
    {
    get;
    set;
    }

}
}