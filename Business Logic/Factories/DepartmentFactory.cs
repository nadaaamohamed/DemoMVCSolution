using Business_Logic.DataTransferObjects;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.Factories
{
    public static class DepartmentFactory
    {
        public static DepartmentDto ToDepartmentDto(this Department D)
        {
            return new DepartmentDto
            {
                deptid = D.Id,
                Code = D.Code,
                Name = D.Name,
                Description = D.Description,
                DateOfCreation = DateOnly.FromDateTime(D.CreatedOn)
            };

        }

        public static DepartmentDetialsDto ToDeparmentDetialsDto(this Department department)
        {
            return new DepartmentDetialsDto
            {
                Id = department.Id,
                Name = department.Name,
                Code = department.Code,
                Description = department.Description,
                CreatedBy = department.CreatedBy,
                CreatedOn = DateOnly.FromDateTime(department.CreatedOn),
                LastModifiedBy = department.LastModifiedBy,
                LastModifiedOn = DateOnly.FromDateTime(department.LastModifiedOn),
                IsDeleted = department.IsDeleted
            };
        }
        public static Department ToEntity(this CreateDepartmentDto departmentDto)
        {
            return new Department
            {
                Name = departmentDto.Name,
                Code = departmentDto.Code,
                Description = departmentDto.Description,
                CreatedOn = departmentDto.DateOfCreation.ToDateTime(new TimeOnly()),
            };
        }
        public static Department ToEntity(this UpdatedDepartmentDto departmentDto)
        {
           return new Department
           {
               Id = departmentDto.Id,
               Name = departmentDto.Name,
               Code = departmentDto.Code,
               Description = departmentDto.Description,
               CreatedOn = departmentDto.DateOfCreation.ToDateTime(new TimeOnly()),

           };
        }
    }
}