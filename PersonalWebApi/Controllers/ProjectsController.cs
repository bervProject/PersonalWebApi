using PersonalWebApi.Models;
using PersonalWebApi.Repositories;

namespace PersonalWebApi.Controllers
{
    public class ProjectsController : DefaultController<Project, ProjectRepositories>
    {
        public ProjectsController(ProjectRepositories repo) : base(repo)
        {
        }
    }
}
