using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalWebApi.Models;
using PersonalWebApi.Repositories;
using System;
using System.Threading.Tasks;

namespace PersonalWebApi.Controllers
{
    public abstract class DefaultRestController<TEntity, TRepository> : ControllerBase
        where TEntity : class, IAuditable
        where TRepository : IDefaultModelRepositories<TEntity>
    {
        private readonly TRepository _repository;
        public DefaultRestController(TRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Get()
        {
            return Ok(_repository.GetAll());
        }

        public IActionResult Get(Guid key)
        {
            return Ok(_repository.Get(key));
        }

        public async Task<IActionResult> Post([FromBody] TEntity entity)
        {
            var createdData = await _repository.Create(entity);
            return Created(createdData.Id.ToString(), createdData);
        }

        public async Task<IActionResult> Put(Guid key, [FromBody] TEntity entity)
        {
            var patchedData = await _repository.Put(key, entity);
            return Ok(patchedData);
        }

        public async Task<IActionResult> Delete(Guid key)
        {
            await _repository.Delete(key);
            return StatusCode(StatusCodes.Status204NoContent);
        }
    }
}
