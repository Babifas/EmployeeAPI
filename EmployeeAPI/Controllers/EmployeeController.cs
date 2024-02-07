using EmployeeAPI.Models;
using EmployeeAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService) 
        {
           _employeeService = employeeService;
        }

        [HttpGet]
        public IActionResult GetAllEmployees()
        {
           return Ok(_employeeService.GetAllEmployees());
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id) {
           return Ok(_employeeService.EmployeeGetById(id));
        }

        [HttpPost]
        public IActionResult AddEmployee([FromBody] EmployeeDto employeedto)
        {
            _employeeService.AddEmployee(employeedto);
            return Ok("Added Successfully");
        }
        [HttpPut("{id}")]
        public IActionResult UpdateEmployee([FromBody] EmployeeDto employeedto, int id) 
        { 
          _employeeService.UpdateEmployee(employeedto,id);
            return Ok("updated successfully");
        }
        [HttpDelete]
        public IActionResult DeleteEmployeeById(int id)
        {
            _employeeService.DeleteEmployee (id);
            return Ok("deleted successfull");
        }
        [HttpGet("Filter Employee By Salary")]
        public IActionResult FilterBySalary( int minsalary,int maxsalary)
        {
            return Ok(_employeeService.FilterEmployeeBySalary(minsalary,maxsalary));
        }
    }
}
