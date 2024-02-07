namespace EmployeeAPI.Models
{
    public class EmployeeDto
    {
        public string? Name { get; set; }
        public string? Job { get; set; }
        public int Salary { get; set; }
        public DateTime JoinDate { get; set; }
        public int departmentId { get; set; }
    }
}
