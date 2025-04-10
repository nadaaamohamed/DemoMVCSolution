

using DataAccess.Models.DepartmentsModels;
using System.Diagnostics.CodeAnalysis;

namespace DataAccess.Data.Configrutions
{
    public class DepartmentConfigrution : BaseEntityConfigrution<Department>,IEntityTypeConfiguration<Department>
    {
        public  new void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(D => D.Id).UseIdentityColumn(10, 10);
            builder.Property(d => d.Name).HasColumnType("varchar(20)");
            builder.Property(d => d.Code).HasColumnType("varchar(20)");
            base.Configure(builder);

        }
    }
}
