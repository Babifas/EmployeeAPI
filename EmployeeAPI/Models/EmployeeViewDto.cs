namespace EmployeeAPI.Models
{
    public class EmployeeViewDto
    {
        public int EmployeeId { get; set; }
        public string? Name { get; set; }
        public string? Job { get; set; }
        public int Salary { get; set; }
        public DateTime JoinDate { get; set; }
        public string? departmentName { get; set; }
    }
}
