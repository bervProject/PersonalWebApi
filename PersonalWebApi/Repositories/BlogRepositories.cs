using PersonalWebApi.EntityFramework;
using PersonalWebApi.Models;

namespace PersonalWebApi.Repositories
{
    public class BlogRepositories : DefaultModelRepositories<Blog, PersonalWebApiContext>
    {
        public BlogRepositories(PersonalWebApiContext context) : base(context)
        {

        }
    }
}
