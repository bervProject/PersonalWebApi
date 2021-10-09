using Microsoft.EntityFrameworkCore;
using PersonalWebApi.Models;

namespace PersonalWebApi.EntityFramework
{
    public class PersonalWebApiContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Project> Projects { get; set; }

        public PersonalWebApiContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
    }
}