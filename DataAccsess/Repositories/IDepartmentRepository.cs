﻿
namespace DataAccess.Repositories
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAll(bool WithTracking = false);
        Department? GetById(int id);
        int Add(Department department);
        int Remove(Department department);
        int Update(Department department);
    }
}