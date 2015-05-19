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

using CloudFoundry.CloudController.V2.Client.Data;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.CodeDom.Compiler;
using System.Net;
using System.Threading.Tasks;

namespace CloudFoundry.CloudController.V2.Client.Test.Fake
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class UserProvidedServiceInstancesEndpoint
{
        [TestMethod]
        public void DeleteUserProvidedServiceInstanceTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                cfClient.UserProvidedServiceInstances.DeleteUserProvidedServiceInstance(guid).Wait();

            }
        }

        [TestMethod]
        public void CreateUserProvidedServiceInstanceTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""8480da86-d508-4c31-b597-4c6ec4dad99a"",
    ""url"": ""/v2/user_provided_service_instances/8480da86-d508-4c31-b597-4c6ec4dad99a"",
    ""created_at"": ""2015-05-19T15:27:04+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""my-user-provided-instance"",
    ""credentials"": {
      ""somekey"": ""somevalue""
    },
    ""space_guid"": ""aeaa5401-be2a-4c35-9520-ee478c9ffda8"",
    ""type"": ""user_provided_service_instance"",
    ""syslog_drain_url"": ""syslog://example.com"",
    ""space_url"": ""/v2/spaces/aeaa5401-be2a-4c35-9520-ee478c9ffda8"",
    ""service_bindings_url"": ""/v2/user_provided_service_instances/8480da86-d508-4c31-b597-4c6ec4dad99a/service_bindings""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                CreateUserProvidedServiceInstanceRequest value = new CreateUserProvidedServiceInstanceRequest();


                var obj = cfClient.UserProvidedServiceInstances.CreateUserProvidedServiceInstance(value).Result;


                Assert.AreEqual("8480da86-d508-4c31-b597-4c6ec4dad99a", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/user_provided_service_instances/8480da86-d508-4c31-b597-4c6ec4dad99a", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-05-19T15:27:04+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("my-user-provided-instance", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("aeaa5401-be2a-4c35-9520-ee478c9ffda8", TestUtil.ToTestableString(obj.SpaceGuid), true);
                Assert.AreEqual("user_provided_service_instance", TestUtil.ToTestableString(obj.Type), true);
                Assert.AreEqual("syslog://example.com", TestUtil.ToTestableString(obj.SyslogDrainUrl), true);
                Assert.AreEqual("/v2/spaces/aeaa5401-be2a-4c35-9520-ee478c9ffda8", TestUtil.ToTestableString(obj.SpaceUrl), true);
                Assert.AreEqual("/v2/user_provided_service_instances/8480da86-d508-4c31-b597-4c6ec4dad99a/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);

            }
        }

        [TestMethod]
        public void RetrieveUserProvidedServiceInstanceTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""4e9625b5-f4ab-4b1f-8a1e-e457b9f235f1"",
    ""url"": ""/v2/user_provided_service_instances/4e9625b5-f4ab-4b1f-8a1e-e457b9f235f1"",
    ""created_at"": ""2015-05-19T15:27:04+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name-100"",
    ""credentials"": {
      ""creds-key-117"": ""creds-val-117""
    },
    ""space_guid"": ""799da27a-2b11-4d54-bc36-73a944f158fb"",
    ""type"": ""user_provided_service_instance"",
    ""syslog_drain_url"": ""https://foo.com/url-10"",
    ""space_url"": ""/v2/spaces/799da27a-2b11-4d54-bc36-73a944f158fb"",
    ""service_bindings_url"": ""/v2/user_provided_service_instances/4e9625b5-f4ab-4b1f-8a1e-e457b9f235f1/service_bindings""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.UserProvidedServiceInstances.RetrieveUserProvidedServiceInstance(guid).Result;


                Assert.AreEqual("4e9625b5-f4ab-4b1f-8a1e-e457b9f235f1", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/user_provided_service_instances/4e9625b5-f4ab-4b1f-8a1e-e457b9f235f1", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-05-19T15:27:04+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-100", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("799da27a-2b11-4d54-bc36-73a944f158fb", TestUtil.ToTestableString(obj.SpaceGuid), true);
                Assert.AreEqual("user_provided_service_instance", TestUtil.ToTestableString(obj.Type), true);
                Assert.AreEqual("https://foo.com/url-10", TestUtil.ToTestableString(obj.SyslogDrainUrl), true);
                Assert.AreEqual("/v2/spaces/799da27a-2b11-4d54-bc36-73a944f158fb", TestUtil.ToTestableString(obj.SpaceUrl), true);
                Assert.AreEqual("/v2/user_provided_service_instances/4e9625b5-f4ab-4b1f-8a1e-e457b9f235f1/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);

            }
        }

        [TestMethod]
        public void ListAllServiceBindingsForUserProvidedServiceInstanceTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""04c9fefa-b022-493c-afea-dcf7bcb4db32"",
        ""url"": ""/v2/service_bindings/04c9fefa-b022-493c-afea-dcf7bcb4db32"",
        ""created_at"": ""2015-05-19T15:27:04+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""app_guid"": ""27294b61-2ca7-4f31-9237-c97cb8422b44"",
        ""service_instance_guid"": ""79c36bc4-f3b9-4233-8c84-27a31eebe4c6"",
        ""credentials"": {
          ""creds-key-111"": ""creds-val-111""
        },
        ""binding_options"": {

        },
        ""gateway_data"": null,
        ""gateway_name"": """",
        ""syslog_drain_url"": null,
        ""app_url"": ""/v2/apps/27294b61-2ca7-4f31-9237-c97cb8422b44"",
        ""service_instance_url"": ""/v2/user_provided_service_instances/79c36bc4-f3b9-4233-8c84-27a31eebe4c6""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.UserProvidedServiceInstances.ListAllServiceBindingsForUserProvidedServiceInstance(guid).Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("04c9fefa-b022-493c-afea-dcf7bcb4db32", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_bindings/04c9fefa-b022-493c-afea-dcf7bcb4db32", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2015-05-19T15:27:04+00:00", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("27294b61-2ca7-4f31-9237-c97cb8422b44", TestUtil.ToTestableString(obj[0].AppGuid), true);
                Assert.AreEqual("79c36bc4-f3b9-4233-8c84-27a31eebe4c6", TestUtil.ToTestableString(obj[0].ServiceInstanceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].GatewayData), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].GatewayName), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].SyslogDrainUrl), true);
                Assert.AreEqual("/v2/apps/27294b61-2ca7-4f31-9237-c97cb8422b44", TestUtil.ToTestableString(obj[0].AppUrl), true);
                Assert.AreEqual("/v2/user_provided_service_instances/79c36bc4-f3b9-4233-8c84-27a31eebe4c6", TestUtil.ToTestableString(obj[0].ServiceInstanceUrl), true);

            }
        }

        [TestMethod]
        public void ListAllUserProvidedServiceInstancesTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""64df917e-c3bd-4e64-8a64-94f772bd4741"",
        ""url"": ""/v2/user_provided_service_instances/64df917e-c3bd-4e64-8a64-94f772bd4741"",
        ""created_at"": ""2015-05-19T15:27:04+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-96"",
        ""credentials"": {
          ""creds-key-114"": ""creds-val-114""
        },
        ""space_guid"": ""143079ec-dfc1-4ae8-914a-fcd3bc200ecf"",
        ""type"": ""user_provided_service_instance"",
        ""syslog_drain_url"": ""https://foo.com/url-9"",
        ""space_url"": ""/v2/spaces/143079ec-dfc1-4ae8-914a-fcd3bc200ecf"",
        ""service_bindings_url"": ""/v2/user_provided_service_instances/64df917e-c3bd-4e64-8a64-94f772bd4741/service_bindings""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.UserProvidedServiceInstances.ListAllUserProvidedServiceInstances().Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("64df917e-c3bd-4e64-8a64-94f772bd4741", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/user_provided_service_instances/64df917e-c3bd-4e64-8a64-94f772bd4741", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2015-05-19T15:27:04+00:00", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-96", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("143079ec-dfc1-4ae8-914a-fcd3bc200ecf", TestUtil.ToTestableString(obj[0].SpaceGuid), true);
                Assert.AreEqual("user_provided_service_instance", TestUtil.ToTestableString(obj[0].Type), true);
                Assert.AreEqual("https://foo.com/url-9", TestUtil.ToTestableString(obj[0].SyslogDrainUrl), true);
                Assert.AreEqual("/v2/spaces/143079ec-dfc1-4ae8-914a-fcd3bc200ecf", TestUtil.ToTestableString(obj[0].SpaceUrl), true);
                Assert.AreEqual("/v2/user_provided_service_instances/64df917e-c3bd-4e64-8a64-94f772bd4741/service_bindings", TestUtil.ToTestableString(obj[0].ServiceBindingsUrl), true);

            }
        }

        [TestMethod]
        public void UpdateUserProvidedServiceInstanceTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""8d20a40e-66f2-4463-a70f-142901f7bc51"",
    ""url"": ""/v2/user_provided_service_instances/8d20a40e-66f2-4463-a70f-142901f7bc51"",
    ""created_at"": ""2015-05-19T15:27:04+00:00"",
    ""updated_at"": ""2015-05-19T15:27:04+00:00""
  },
  ""entity"": {
    ""name"": ""name-115"",
    ""credentials"": {
      ""somekey"": ""somenewvalue""
    },
    ""space_guid"": ""aa90c089-9ea3-4760-bba9-1b66fb08bed1"",
    ""type"": ""user_provided_service_instance"",
    ""syslog_drain_url"": ""https://foo.com/url-13"",
    ""space_url"": ""/v2/spaces/aa90c089-9ea3-4760-bba9-1b66fb08bed1"",
    ""service_bindings_url"": ""/v2/user_provided_service_instances/8d20a40e-66f2-4463-a70f-142901f7bc51/service_bindings""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                UpdateUserProvidedServiceInstanceRequest value = new UpdateUserProvidedServiceInstanceRequest();


                var obj = cfClient.UserProvidedServiceInstances.UpdateUserProvidedServiceInstance(guid, value).Result;


                Assert.AreEqual("8d20a40e-66f2-4463-a70f-142901f7bc51", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/user_provided_service_instances/8d20a40e-66f2-4463-a70f-142901f7bc51", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-05-19T15:27:04+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2015-05-19T15:27:04+00:00", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-115", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("aa90c089-9ea3-4760-bba9-1b66fb08bed1", TestUtil.ToTestableString(obj.SpaceGuid), true);
                Assert.AreEqual("user_provided_service_instance", TestUtil.ToTestableString(obj.Type), true);
                Assert.AreEqual("https://foo.com/url-13", TestUtil.ToTestableString(obj.SyslogDrainUrl), true);
                Assert.AreEqual("/v2/spaces/aa90c089-9ea3-4760-bba9-1b66fb08bed1", TestUtil.ToTestableString(obj.SpaceUrl), true);
                Assert.AreEqual("/v2/user_provided_service_instances/8d20a40e-66f2-4463-a70f-142901f7bc51/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);

            }
        }

    }
}