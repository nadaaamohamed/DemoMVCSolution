using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.DataTransferObjects
{
    public class DepartmentDetialsDto
    {
        //Constructor Mapping
        //public DepartmentDetialsDto(Department department)
        //{
        //    Id = department.Id;
        //    Name = department.Name;
        //    Code = department.Code;
        //    Description = department.Description;
        //    CreatedBy = department.CreatedBy;
        //    CreatedOn = DateOnly.FromDateTime(department.CreatedOn);
        //    LastModifiedBy = department.LastModifiedBy;
        //    LastModifiedOn = DateOnly.FromDateTime(department.LastModifiedOn);
        //    IsDeleted = department.IsDeleted;
        //}
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int Id { get; set; }
        public int CreatedBy { get; set; } //user id
        public DateOnly CreatedOn { get; set; }
        public int LastModifiedBy { get; set; } //user id
        public DateOnly LastModifiedOn { get; set; } //Auto Calculate
        public bool IsDeleted { get; set; } //soft delete
    }
}
