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

using CloudFoundry.CloudController.V2.Client;
using CloudFoundry.CloudController.V2.Client.Data;
using Microsoft.CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.CodeDom.Compiler;

namespace CloudFoundry.CloudController.V2.Test.Deserialization
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class SecurityGroupStagingDefaultsTest
    {


        [TestMethod]
        public void TestSetSecurityGroupAsDefaultForStagingResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""a91fe095-6f93-40a5-a01a-393461c54aa6"",
    ""url"": ""/v2/config/staging_security_groups/a91fe095-6f93-40a5-a01a-393461c54aa6"",
    ""created_at"": ""2016-02-09T10:21:41Z"",
    ""updated_at"": ""2016-02-09T10:21:41Z""
  },
  ""entity"": {
    ""name"": ""name-1"",
    ""rules"": [
      {
        ""protocol"": ""udp"",
        ""ports"": ""8080"",
        ""destination"": ""198.41.191.47/1""
      }
    ],
    ""running_default"": false,
    ""staging_default"": true
  }
}";

            SetSecurityGroupAsDefaultForStagingResponse obj = Utilities.DeserializeJson<SetSecurityGroupAsDefaultForStagingResponse>(json);

            Assert.AreEqual("a91fe095-6f93-40a5-a01a-393461c54aa6", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/config/staging_security_groups/a91fe095-6f93-40a5-a01a-393461c54aa6", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-09T10:21:41Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2016-02-09T10:21:41Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-1", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.RunningDefault), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.StagingDefault), true);
        }

        [TestMethod]
        public void TestReturnSecurityGroupsUsedForStagingResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""6749a987-ecfa-4b48-b916-3ed2b44e7251"",
        ""url"": ""/v2/config/staging_security_groups/6749a987-ecfa-4b48-b916-3ed2b44e7251"",
        ""created_at"": ""2016-02-09T10:21:41Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-6"",
        ""rules"": [
          {
            ""protocol"": ""udp"",
            ""ports"": ""8080"",
            ""destination"": ""198.41.191.47/1""
          }
        ],
        ""running_default"": false,
        ""staging_default"": true
      }
    }
  ]
}";

            PagedResponseCollection<ReturnSecurityGroupsUsedForStagingResponse> page = Utilities.DeserializePage<ReturnSecurityGroupsUsedForStagingResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("6749a987-ecfa-4b48-b916-3ed2b44e7251", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/config/staging_security_groups/6749a987-ecfa-4b48-b916-3ed2b44e7251", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-09T10:21:41Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-6", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[0].RunningDefault), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(page[0].StagingDefault), true);
        }
    }
}
