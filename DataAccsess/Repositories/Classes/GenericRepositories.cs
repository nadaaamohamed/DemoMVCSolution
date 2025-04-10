using DataAccess.Data.Contexts;
using DataAccess.Models.DepartmentModel;
using DataAccess.Models.Shared;
using DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Classes
{
    public class GenericRepositories<TEntity>(ApplicationDbContext _dbContext) : IGenericRepositories<TEntity> where TEntity : BaseEntity
    {

        //CRUD Operations
        //Get All
        public IEnumerable<TEntity> GetAll(bool WithTracking = false)
        {
            if (WithTracking)
                return _dbContext.Set<TEntity>().ToList();
            else
                return _dbContext.Set<TEntity>().AsNoTracking().ToList();
        }
        //Get By Id
        public TEntity? GetById(int id) => _dbContext.Set<TEntity>().Find(id);

        //Update
        public int Update(TEntity department)
        {
            _dbContext.Set<TEntity>().Update(department); //Update locally
            return _dbContext.SaveChanges(); //Save to database
        }
        //Delete
        public int Remove(TEntity department)
        {
            _dbContext.Set<TEntity>().Remove(department); //Remove locally
            return _dbContext.SaveChanges(); //Save to database
        }
        //Insert
        public int Add(TEntity department)
        {
            _dbContext.Set<TEntity>().Add(department); //Insert locally
            return _dbContext.SaveChanges(); //Save to database
        }
    }
}
