using DataAccess.Data.Contexts;
using DataAccess.Models.EmployeeModel;
using DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Classes
{
    internal class EmployeeRepositories (ApplicationDbContext _dbContext) : GenericRepositories<Employee> (_dbContext),IEmployeeRepositories
    {
        

    }
}
