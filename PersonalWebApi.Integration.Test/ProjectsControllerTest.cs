using Microsoft.AspNetCore.Mvc.Testing;
using PersonalWebApi.Integration.Test.Models;
using PersonalWebApi.Models;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Xunit;

namespace PersonalWebApi.Integration.Test
{
    public class ProjectsControllerTest : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly WebApplicationFactory<Program> _factory;
        private readonly string _baseUrl = "/v1/Projects";

        public ProjectsControllerTest(WebApplicationFactory<Program> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task Get()
        {
            var client = _factory.CreateClient();
            var response = await client.GetAsync(_baseUrl);
            response.EnsureSuccessStatusCode();
            var bodyResponse = await response.Content.ReadFromJsonAsync<ODataListResponse<Project>>();
            var emptyResult = new List<Project>();
            Assert.Equal(emptyResult, bodyResponse.Value);
        }
    }
}
