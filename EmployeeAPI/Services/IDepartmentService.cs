using EmployeeAPI.Models;

namespace EmployeeAPI.Services
{
    public interface IDepartmentService
    {
       List<Department> GetAllDepartments();
       void AddDepartment(DepartmentDto departmentDto);
    }
}
