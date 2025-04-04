using DataAccess.Models;
using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.Servies
{
    internal class DepartmentServies
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentServies(IDepartmentRepository departmentRepository)
        {
           this. _departmentRepository = departmentRepository;
        }
       //public int Test()
       // {
       //      List<Department> Departments = _departmentRepository.GetAll().ToList();
       // }
    }
}
