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
    public class JobsEndpoint
{
        [TestMethod]
        public void RetrieveJobThatWasSuccessfulTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""0"",
    ""created_at"": ""1970-01-01T00:00:00+00:00"",
    ""url"": ""/v2/jobs/0""
  },
  ""entity"": {
    ""guid"": ""0"",
    ""status"": ""finished""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.Jobs.RetrieveJobThatWasSuccessful(guid).Result;


                Assert.AreEqual("0", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("1970-01-01T00:00:00+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("/v2/jobs/0", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("0", TestUtil.ToTestableString(obj.Guid), true);
                Assert.AreEqual("finished", TestUtil.ToTestableString(obj.Status), true);

            }
        }

        [TestMethod]
        public void RetrieveJobWithKnownFailureTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""c02ddf68-f87c-47a6-8a9b-fad36ce56103"",
    ""created_at"": ""2015-05-19T15:27:01+00:00"",
    ""url"": ""/v2/jobs/c02ddf68-f87c-47a6-8a9b-fad36ce56103""
  },
  ""entity"": {
    ""guid"": ""c02ddf68-f87c-47a6-8a9b-fad36ce56103"",
    ""status"": ""failed"",
    ""error"": ""Use of entity>error is deprecated in favor of entity>error_details."",
    ""error_details"": {
      ""code"": 1001,
      ""description"": ""Request invalid due to parse error: arbitrary string"",
      ""error_code"": ""CF-MessageParseError""
    }
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.Jobs.RetrieveJobWithKnownFailure(guid).Result;


                Assert.AreEqual("c02ddf68-f87c-47a6-8a9b-fad36ce56103", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("2015-05-19T15:27:01+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("/v2/jobs/c02ddf68-f87c-47a6-8a9b-fad36ce56103", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("c02ddf68-f87c-47a6-8a9b-fad36ce56103", TestUtil.ToTestableString(obj.Guid), true);
                Assert.AreEqual("failed", TestUtil.ToTestableString(obj.Status), true);
                Assert.AreEqual("Use of entity>error is deprecated in favor of entity>error_details.", TestUtil.ToTestableString(obj.Error), true);

            }
        }

        [TestMethod]
        public void RetrieveJobThatIsQueuedTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""f0a57fb3-3442-4fcc-b550-cf51efa04afa"",
    ""created_at"": ""2015-05-19T15:27:01+00:00"",
    ""url"": ""/v2/jobs/f0a57fb3-3442-4fcc-b550-cf51efa04afa""
  },
  ""entity"": {
    ""guid"": ""f0a57fb3-3442-4fcc-b550-cf51efa04afa"",
    ""status"": ""queued""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.Jobs.RetrieveJobThatIsQueued(guid).Result;


                Assert.AreEqual("f0a57fb3-3442-4fcc-b550-cf51efa04afa", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("2015-05-19T15:27:01+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("/v2/jobs/f0a57fb3-3442-4fcc-b550-cf51efa04afa", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("f0a57fb3-3442-4fcc-b550-cf51efa04afa", TestUtil.ToTestableString(obj.Guid), true);
                Assert.AreEqual("queued", TestUtil.ToTestableString(obj.Status), true);

            }
        }

        [TestMethod]
        public void RetrieveJobWithUnknownFailureTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""38b72ca8-29d2-4c34-94d7-619a1a3c4512"",
    ""created_at"": ""2015-05-19T15:27:01+00:00"",
    ""url"": ""/v2/jobs/38b72ca8-29d2-4c34-94d7-619a1a3c4512""
  },
  ""entity"": {
    ""guid"": ""38b72ca8-29d2-4c34-94d7-619a1a3c4512"",
    ""status"": ""failed"",
    ""error"": ""Use of entity>error is deprecated in favor of entity>error_details."",
    ""error_details"": {
      ""error_code"": ""UnknownError"",
      ""description"": ""An unknown error occurred."",
      ""code"": 10001
    }
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.Jobs.RetrieveJobWithUnknownFailure(guid).Result;


                Assert.AreEqual("38b72ca8-29d2-4c34-94d7-619a1a3c4512", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("2015-05-19T15:27:01+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("/v2/jobs/38b72ca8-29d2-4c34-94d7-619a1a3c4512", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("38b72ca8-29d2-4c34-94d7-619a1a3c4512", TestUtil.ToTestableString(obj.Guid), true);
                Assert.AreEqual("failed", TestUtil.ToTestableString(obj.Status), true);
                Assert.AreEqual("Use of entity>error is deprecated in favor of entity>error_details.", TestUtil.ToTestableString(obj.Error), true);

            }
        }

    }
}