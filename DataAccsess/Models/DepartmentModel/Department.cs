using DataAccess.Models.Shared;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models.DepartmentModel
{
    public class Department : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string? Description { get; set; }
    }
}
