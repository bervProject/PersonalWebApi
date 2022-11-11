using Microsoft.AspNetCore.Mvc;
using PersonalWebApi.Models;
using PersonalWebApi.Repositories;

namespace PersonalWebApi.Controllers
{
    [Route("/api/[controller]/[action]")]
    [ApiController]
    public class BlogsRestController : DefaultRestController<Blog, BlogRepositories>
    {
        public BlogsRestController(BlogRepositories repo) : base(repo)
        {
        }
    }
}