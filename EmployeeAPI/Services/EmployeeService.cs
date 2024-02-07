using AutoMapper;
using EmployeeAPI.Data;
using EmployeeAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAPI.Services
{
    public class EmployeeService:IEmployeeService
    {
        private  readonly EmployeeDbContext _context;
        private  readonly IMapper _mapper;
        public EmployeeService(EmployeeDbContext context,IMapper mapper) 
        {
              _context = context;
              _mapper = mapper;
        }
        public List<EmployeeViewDto> GetAllEmployees()
        {
            var employee = _context.Employees.Include(e => e.department).ToList();
            var employeedeatails = employee.Select(e => new EmployeeViewDto
            {
                EmployeeId = e.EmployeeId,
                Name = e.Name,
                Job=e.Job,
                Salary=e.Salary,
                JoinDate= e.JoinDate,
                departmentName=e.department.deptName
            });
            return employeedeatails.ToList();
        }
        public EmployeeViewDto EmployeeGetById(int id)
        {
            return _mapper.Map<EmployeeViewDto>(_context.Employees.Find(id));
        }
        public void AddEmployee(EmployeeDto employeedto)
        {
            var employee=_mapper.Map<Employee>(employeedto);
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }
        public void UpdateEmployee(EmployeeDto employeedto, int id)
        {
           var emp=_context.Employees.Find(id);
           emp.Name= employeedto.Name;
           emp.Job= employeedto.Job;
           emp.Salary = employeedto.Salary;
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
