using PersonalWebApi.EntityFramework;
using PersonalWebApi.Models;

namespace PersonalWebApi.Repositories
{
    public class ProjectRepositories : DefaultModelRepositories<Project, PersonalWebApiContext>
    {
        public ProjectRepositories(PersonalWebApiContext context) : base(context)
        {

        }
    }
}
