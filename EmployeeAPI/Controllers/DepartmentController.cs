using EmployeeAPI.Models;
using EmployeeAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;
        public DepartmentController(IDepartmentService departmentService) {

            _departmentService = departmentService;    
        }
        [HttpGet]
        public IActionResult GetAllDepartments()
        {
            return Ok(_departmentService.GetAllDepartments());
        }
        [HttpPost]
        public IActionResult AddDepartment(DepartmentDto departmentDto)
        {
            _departmentService.AddDepartment(departmentDto);
            return Ok("added successfully");
        }
    }
}
