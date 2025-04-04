using DataAccess.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    //Primary Constructor .Net 8 C#12
    public class DepartmentRepository(ApplicationDbContext _dbContext) : IDepartmentRepository
    {
        //private readonly ApplicationDbContext _dbContext = dbContext;

        //CRUD Operations
        //Get All
        public IEnumerable<Department> GetAll(bool WithTracking = false)
        {
            if (WithTracking)
                return _dbContext.Departments.ToList();
            else
                return _dbContext.Departments.AsNoTracking().ToList();
        }
        //Get By Id
        public Department? GetById(int id) => _dbContext.Departments.Find(id);

        //Update
        public int Update(Department department)
        {
            _dbContext.Departments.Update(department); //Update locally
            return _dbContext.SaveChanges(); //Save to database
        }
        //Delete
        public int Remove(Department department)
        {
            _dbContext.Departments.Remove(department); //Remove locally
            return _dbContext.SaveChanges(); //Save to database
        }
        //Insert
        public int Insert(Department department)
        {
            _dbContext.Departments.Add(department); //Insert locally
            return _dbContext.SaveChanges(); //Save to database
        }
    }
}
