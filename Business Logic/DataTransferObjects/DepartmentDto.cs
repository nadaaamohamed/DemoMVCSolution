using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.DataTransferObjects
{
    public class DepartmentDto
    {
        public int deptid { get; set; }
        public string Code { get; set; }=string.Empty;
        public string Name { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateOnly DateOfCreation { get; set; }
    }
}
