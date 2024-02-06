using System.ComponentModel.DataAnnotations;

namespace EmployeeAPI.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string? Name { get; set; }
        public string? Job {  get; set; }
        public int Salary { get; set; } 
        public DateTime JoinDate {  get; set; }
    }
}
