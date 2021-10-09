using Microsoft.AspNetCore.OData.Deltas;
using PersonalWebApi.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalWebApi.Repositories
{
    public interface IDefaultModelRepositories<TEntity>
        where TEntity : class, IAuditable
    {
        IQueryable<TEntity> GetAll();
        TEntity Get(Guid key);
        Task<TEntity> Create(TEntity data);
        Task<TEntity> Patch(Guid key, Delta<TEntity> updatedData);
        Task Delete(Guid key);
    }
}
