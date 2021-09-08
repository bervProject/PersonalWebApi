using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using PersonalWebApi.EntityFramework;
using PersonalWebApi.Models;

namespace PersonalWebApi.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class BlogsController : ODataController
    {
        private readonly PersonalWebApiContext _dbContext;
        public BlogsController(PersonalWebApiContext dbContext)
        {
            _dbContext = dbContext;
        }

        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_defaultQuery());
        }

        [EnableQuery]
        public IActionResult Get(Guid key)
        {
            return Ok(_defaultQuery().FirstOrDefault(c => c.Id == key));
        }

        [EnableQuery]
        public IActionResult Post([FromBody]Blog book)
        {
            _dbContext.Blogs.Add(book);
            _dbContext.SaveChanges();
            return Created(book);
        }

        [EnableQuery]
        public IActionResult Delete([FromBody] Guid key)
        {
            Blog b = _dbContext.Blogs.FirstOrDefault(c => c.Id == key);
            if (b == null)
            {
                return NotFound();
            }
            b.IsDeleted = true;
            _dbContext.SaveChanges();
            return Ok();
        }

        private IQueryable<Blog> _defaultQuery()
        {
            return _dbContext.Blogs.Where(blog => !blog.IsDeleted);
        }
    }
}