using EmployeeAPI.Data;
using EmployeeAPI.Models;

namespace EmployeeAPI.Services
{
    public class EmployeeService:IEmployeeService
    {
        private  readonly EmployeeDbContext _context;
        public EmployeeService(EmployeeDbContext context) 
        {
              _context = context;
        }
        public List<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }
        public Employee EmployeeGetById(int id)
        {
            return _context.Employees.Find(id);
        }
        public void AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }
        public void UpdateEmployee(Employee employee, int id)
        {
           var emp=_context.Employees.Find(id);
           emp.Name= employee.Name;
           emp.Job= employee.Job;
           emp.Salary = employee.Salary;
           emp.JoinDate = DateTime.Now;
           _context.SaveChanges();
        }
        public void DeleteEmployee(int id)
        {
            var emp= _context.Employees.Find(id);
               _context.Employees.Remove(emp);
               _context.SaveChanges();
        }
        public List<Employee> FilterEmployeeBySalary(int minsalary, int maxsalary)
        {
            var employees= _context.Employees.Where(emp=>minsalary<emp.Salary&&emp.Salary<maxsalary);
            return employees.ToList();
        }
    }
}
