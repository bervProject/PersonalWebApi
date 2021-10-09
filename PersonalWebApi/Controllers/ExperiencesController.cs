using PersonalWebApi.Models;
using PersonalWebApi.Repositories;

namespace PersonalWebApi.Controllers
{
    public class ExperiencesController : DefaultController<Experience, ExperienceRepositories>
    {
        public ExperiencesController(ExperienceRepositories repo) : base(repo)
        {
        }
    }
}