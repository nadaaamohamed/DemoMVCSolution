using DataAccess.Models.EmployeeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Interfaces
{
    public interface IEmployeeRepositories :IGenericRepositories<Employee>
    {
        
    }
}
