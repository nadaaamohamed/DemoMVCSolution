using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.DataTransferObjects
{
    public class CreateDepartmentDto
    {
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
       public DateOnly DateOfCreation { get; set; }
        public string? Description { get; set; }
        
    }
}
