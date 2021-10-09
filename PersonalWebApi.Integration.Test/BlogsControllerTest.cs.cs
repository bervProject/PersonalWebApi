using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.OData;
using PersonalWebApi.Integration.Test.Models;
using PersonalWebApi.Models;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Xunit;

namespace PersonalWebApi.Integration.Test
{
    public class BlogsControllerTest : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;
        private readonly string _baseUrl = "/v1/Blogs";

        public BlogsControllerTest(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task Get()
        {
            var client = _factory.CreateClient();
            var response = await client.GetAsync(_baseUrl);
            response.EnsureSuccessStatusCode();
            var bodyResponse = await response.Content.ReadFromJsonAsync<ODataListResponse<Blog>>();
            var emptyResult = new List<Blog>();
            Assert.Equal(emptyResult, bodyResponse.Value);
        }
    }
}
