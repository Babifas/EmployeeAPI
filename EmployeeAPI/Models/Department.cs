using System.ComponentModel.DataAnnotations;

namespace EmployeeAPI.Models
{
    public class Department
    {
        [Key]
        public int deptId { get; set; }
        public string? deptName { get; set; }
        public List<Employee>? employees { get; set;}

    }
}
