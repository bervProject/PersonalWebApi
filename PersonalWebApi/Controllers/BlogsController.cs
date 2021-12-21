using Microsoft.AspNetCore.Mvc;
using PersonalWebApi.Models;
using PersonalWebApi.Repositories;

namespace PersonalWebApi.Controllers
{
    [Route("/api/[controller]/[action]")]
    [ApiController]
    public class BlogsController : DefaultRestController<Blog, BlogRepositories>
    {
        public BlogsController(BlogRepositories repo) : base(repo)
        {
        }
    }
}