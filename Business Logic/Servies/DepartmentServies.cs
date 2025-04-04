using Business_Logic.DataTransferObjects;
using Business_Logic.Factories;
using DataAccess.Models;
using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.Servies
{
    public class DepartmentServies(IDepartmentRepository _departmentRepository) : IDepartmentServies
    {
        #region MyRegion
        //private readonly IDepartmentRepository _departmentRepository = departmentRepository;
        //public int Test()
        // {
        //      List<Department> Departments = _departmentRepository.GetAll().ToList();
        // } 
        #endregion

        //Get All Departments 
        public IEnumerable<DepartmentDto> GetAllDepartments()
        {
            var departments = _departmentRepository.GetAll();
            return departments.Select(D => D.ToDepartmentDto());

        }
        //Get Department By Id
        public DepartmentDetialsDto? GetDepartmentById(int id)
        {
            var department = _departmentRepository.GetById(id);
            //if (department is null) return null;
            //else
            //{
            //    var departmentToReturn = new DepartmentDetialsDto
            //    {
            //        Id = department.Id,
            //        Name = department.Name,
            //        Code = department.Code,
            //        Description = department.Description,
            //        CreatedBy = department.CreatedBy,
            //        CreatedOn = DateOnly.FromDateTime(department.CreatedOn),
            //        LastModifiedBy = department.LastModifiedBy,
            //        LastModifiedOn = DateOnly.FromDateTime(department.LastModifiedOn),
            //        IsDeleted = department.IsDeleted
            //    };

            //}
            //Manually Mapping
            //Auto Mapper
            //Constructor Mapping
            //Extension Method Mapping

            return department is null ? null : department.ToDeparmentDetialsDto();



        }

        //Create Department
        public int AddDepartment(CreateDepartmentDto departmentDto)
        {
            return _departmentRepository.Add(departmentDto.ToEntity());

        }
        //Update Department
        public int UpdateDepartment(UpdatedDepartmentDto departmentDto)
            => _departmentRepository.Update(departmentDto.ToEntity());
        //Delete Department
        public bool DeleteDepartment(int id)
        {
            var department = _departmentRepository.GetById(id);
            if (department is null) return false;
            else
            {
                int result = _departmentRepository.Remove(department);
                return result > 0;
            }





        }
    }
}
