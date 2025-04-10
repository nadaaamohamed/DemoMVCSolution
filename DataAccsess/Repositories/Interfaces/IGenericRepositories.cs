using DataAccess.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Interfaces
{
    public interface IGenericRepositories<TEntity> where TEntity : BaseEntity
    {
        IEnumerable<TEntity> GetAll(bool WithTracking = false);
        TEntity? GetById(int id);
        int Add(TEntity entity);
        int Remove(TEntity entity);
        int Update(TEntity entity);
    }
}
   
