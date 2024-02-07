using AutoMapper;
using EmployeeAPI.Data;
using EmployeeAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAPI.Services
{
    public class DepartmentService:IDepartmentService
    {
        private readonly EmployeeDbContext _context;
        private readonly IMapper _mapper;

        public DepartmentService(EmployeeDbContext dbContext,IMapper mapper)
        {
           _context = dbContext;
            _mapper = mapper;
        }
        public List<Department> GetAllDepartments()
        {
            var dept=_context.Departments.Include(d=>d.employees).ToList();
            var departments = dept.Select(d => new Department
            {
                deptId = d.deptId,
                deptName = d.deptName,
                employees = d.employees.Select(e => new Employee
                {   EmployeeId= e.EmployeeId,
                    Name=e.Name,
                    Job=e.Job,
                    JoinDate=e.JoinDate,
                    Salary=e.Salary,
                    departmentId=e.departmentId
                }).ToList()
                
            }).ToList();
            return departments;
        }
        public void AddDepartment(DepartmentDto departmentDto)
        {
            var department = _mapper.Map<Department>(departmentDto);
            _context.Departments.Add(department);
            _context.SaveChanges();
        }
    }
}
