

namespace DataAccess.Models
{
    public class BaseEntity
    {
        public int Id { get; set; } 
        public int CreatedBy { get; set; } //user id
        public DateTime CreatedOn { get; set; } 
        public int LastModifiedBy { get; set; } //user id
        public DateTime LastModifiedOn { get; set; } //Auto Calculate
        public bool IsDeleted { get; set; } //soft delete
    }
}
