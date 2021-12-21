using PersonalWebApi.Models;
using PersonalWebApi.Repositories;

namespace PersonalWebApi.Controllers.OData
{
    public class ExperiencesController : DefaultController<Experience, ExperienceRepositories>
    {
        public ExperiencesController(ExperienceRepositories repo) : base(repo)
        {
        }
    }
}