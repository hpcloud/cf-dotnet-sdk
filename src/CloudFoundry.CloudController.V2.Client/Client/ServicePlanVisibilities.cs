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
    public partial class ServicePlanVisibilitiesEndpoint : CloudFoundry.CloudController.V2.Client.Base.AbstractServicePlanVisibilitiesEndpoint
    {
        public ServicePlanVisibilitiesEndpoint(CloudFoundryClient client) : base()
        {
            this.CloudTarget = client.CloudTarget;
            this.CancellationToken = client.CancellationToken;
            this.DependencyLocator = client.DependencyLocator;
            this.Auth = client.Auth;
        }    
    }
}

namespace CloudFoundry.CloudController.V2.Client.Base
{

    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractServicePlanVisibilitiesEndpoint : BaseEndpoint
    {

        /// <summary>
        /// List all Service Plan Visibilities
        /// </summary>
        public async Task<PagedResponseCollection<ListAllServicePlanVisibilitiesResponse>> ListAllServicePlanVisibilities()
        {
            return await ListAllServicePlanVisibilities(new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListAllServicePlanVisibilitiesResponse>> ListAllServicePlanVisibilities(RequestOptions options)
        {
            string route = "/v2/service_plan_visibilities";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllServicePlanVisibilitiesResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Creating a Service Plan Visibility
        /// </summary>
        public async Task<CreateServicePlanVisibilityResponse> CreateServicePlanVisibility(CreateServicePlanVisibilityRequest value)
        {
            string route = "/v2/service_plan_visibilities";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Post;
            client.Headers.Add(BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            client.Content = JsonConvert.SerializeObject(value).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<CreateServicePlanVisibilityResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Delete a Particular Service Plan Visibilities
        /// </summary>
        public async Task DeleteServicePlanVisibilities(Guid? guid)
        {
            string route = string.Format("/v2/service_plan_visibilities/{0}", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Delete;
            client.Headers.Add(BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }

        /// <summary>
        /// Updating a Service Plan Visibility
        /// </summary>
        public async Task<UpdateServicePlanVisibilityResponse> UpdateServicePlanVisibility(Guid? guid, UpdateServicePlanVisibilityRequest value)
        {
            string route = string.Format("/v2/service_plan_visibilities/{0}", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Put;
            client.Headers.Add(BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            client.Content = JsonConvert.SerializeObject(value).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<UpdateServicePlanVisibilityResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Retrieve a Particular Service Plan Visibility
        /// </summary>
        public async Task<RetrieveServicePlanVisibilityResponse> RetrieveServicePlanVisibility(Guid? guid)
        {
            string route = string.Format("/v2/service_plan_visibilities/{0}", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RetrieveServicePlanVisibilityResponse>(await response.ReadContentAsStringAsync());
        }
    }
}