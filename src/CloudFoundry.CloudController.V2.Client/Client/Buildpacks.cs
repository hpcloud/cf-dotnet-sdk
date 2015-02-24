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

using CloudFoundry.CloudController.Common;
using CloudFoundry.CloudController.V2.Client.Data;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;


namespace CloudFoundry.CloudController.V2.Client
{
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class BuildpacksEndpoint : CloudFoundry.CloudController.V2.Client.Base.BuildpacksEndpoint
    {
        public BuildpacksEndpoint(CloudFoundryClient client) : base()
        {
            this.CloudTarget = client.CloudTarget;
            this.CancellationToken = client.CancellationToken;
            this.ServiceLocator = client.ServiceLocator;
            this.Auth = client.Auth;
        }    
    }
}

namespace CloudFoundry.CloudController.V2.Client.Base
{

    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class BuildpacksEndpoint : BaseEndpoint
    {

        /// <summary>
        /// Change the position of a Buildpack
        /// </summary>
        /// Buildpacks are maintained in an ordered list.  If the target position is already occupied,
        /// the entries will be shifted down the list to make room.  If the target position is beyond
        /// the end of the current list, the buildpack will be positioned at the end of the list.
        public async Task<ChangePositionOfBuildpackResponse> ChangePositionOfBuildpack(Guid? guid, ChangePositionOfBuildpackRequest value)
        {
            string route = string.Format("/v2/buildpacks/{0}", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Put;
            client.Headers.Add(BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            client.Content = JsonConvert.SerializeObject(value).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<ChangePositionOfBuildpackResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Lock or unlock a Buildpack
        /// </summary>
        public async Task<LockOrUnlockBuildpackResponse> LockOrUnlockBuildpack(Guid? guid, LockOrUnlockBuildpackRequest value)
        {
            string route = string.Format("/v2/buildpacks/{0}", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Put;
            client.Headers.Add(BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            client.Content = JsonConvert.SerializeObject(value).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<LockOrUnlockBuildpackResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Enable or disable a Buildpack
        /// </summary>
        public async Task<EnableOrDisableBuildpackResponse> EnableOrDisableBuildpack(Guid? guid, EnableOrDisableBuildpackRequest value)
        {
            string route = string.Format("/v2/buildpacks/{0}", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Put;
            client.Headers.Add(BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            client.Content = JsonConvert.SerializeObject(value).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<EnableOrDisableBuildpackResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Retrieve a Particular Buildpack
        /// </summary>
        public async Task<RetrieveBuildpackResponse> RetrieveBuildpack(Guid? guid)
        {
            string route = string.Format("/v2/buildpacks/{0}", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RetrieveBuildpackResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Creates an admin Buildpack
        /// </summary>
        public async Task<CreatesAdminBuildpackResponse> CreatesAdminBuildpack(CreatesAdminBuildpackRequest value)
        {
            string route = "/v2/buildpacks";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Post;
            client.Headers.Add(BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            client.Content = JsonConvert.SerializeObject(value).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<CreatesAdminBuildpackResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Buildpacks
        /// </summary>
        public async Task<PagedResponseCollection<ListAllBuildpacksResponse>> ListAllBuildpacks()
        {
            return await ListAllBuildpacks(new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListAllBuildpacksResponse>> ListAllBuildpacks(RequestOptions options)
        {
            string route = "/v2/buildpacks";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllBuildpacksResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Delete a Particular Buildpack
        /// </summary>
        public async Task DeleteBuildpack(Guid? guid)
        {
            string route = string.Format("/v2/buildpacks/{0}", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Delete;
            client.Headers.Add(BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }
    }
}