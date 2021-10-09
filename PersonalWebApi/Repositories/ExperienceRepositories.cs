using PersonalWebApi.EntityFramework;
using PersonalWebApi.Models;

namespace PersonalWebApi.Repositories
{
    public class ExperienceRepositories : DefaultModelRepositories<Experience, PersonalWebApiContext>
    {
        public ExperienceRepositories(PersonalWebApiContext context) : base(context)
        {

        }
    }
}
