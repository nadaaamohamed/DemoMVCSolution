

using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class Department : BaseEntity  
    {
        public string Name { get; set; }
        public string Code { get; set; } 
        public string ?Description { get; set; }
    }
}
