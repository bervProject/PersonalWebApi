using PersonalWebApi.Models;
using PersonalWebApi.Repositories;

namespace PersonalWebApi.Controllers.OData
{
    public class BlogsController : DefaultController<Blog, BlogRepositories>
    {
        public BlogsController(BlogRepositories repo) : base(repo)
        {
        }
    }
}