using EmployeeAPI.Models;

namespace EmployeeAPI.Services
{
    public interface IEmployeeService
    {
      List<EmployeeViewDto> GetAllEmployees();
      EmployeeViewDto EmployeeGetById(int id);
      void AddEmployee(EmployeeDto employeedto);
      void UpdateEmployee(EmployeeDto employeedto,int id);
      void DeleteEmployee(int id);
      List<Employee> FilterEmployeeBySalary(int minsalary,int maxsalary);


    }
}
