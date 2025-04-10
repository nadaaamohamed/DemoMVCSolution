using DataAccess.Data.Contexts;
using DataAccess.Models.DepartmentModel;
using DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Classes
{
    //Primary Constructor .Net 8 C#12
    public class DepartmentRepository(ApplicationDbContext _dbContext) :GenericRepositories<Department> (_dbContext), IDepartmentRepository
    {
        
    }
}
