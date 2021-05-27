using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooBook.Domain.Entities;

namespace ZooBook.Domain.Interfaces
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        Task<List<TEntity>> GetAll();

        Task<TEntity> Get(string id);

        Task Insert(TEntity entity);

        Task Update(string id, TEntity entity);

        Task Delete(string id);
        Task<bool> IsExists(string id);
    }
}
