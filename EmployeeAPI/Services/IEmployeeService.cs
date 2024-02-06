using EmployeeAPI.Models;

namespace EmployeeAPI.Services
{
    public interface IEmployeeService
    {
      List<Employee> GetAllEmployees();
      Employee EmployeeGetById(int id);
      void AddEmployee(Employee employee);
      void UpdateEmployee(Employee employee,int id);
      void DeleteEmployee(int id);
      List<Employee> FilterEmployeeBySalary(int minsalary,int maxsalary);


    }
}
