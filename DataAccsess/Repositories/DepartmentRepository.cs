using DataAccess.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    //Primary Constructor .Net 8 C#12
    internal class DepartmentRepository(ApplicationDbContext _dbContext)
    {
        //private readonly ApplicationDbContext _dbContext = dbContext;

        //CRUD Operations
        //Get All
        //Get By Id
        public Department? GetById(int id)
        {
           var department= _dbContext.Departments.FirstOrDefault(x => x.Id == id);
            return department;
        }
        //Update
        //Delete
        //Insert
    }
}
