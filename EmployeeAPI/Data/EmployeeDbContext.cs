using EmployeeAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAPI.Data
{
    public class EmployeeDbContext:DbContext
    {
         public EmployeeDbContext(DbContextOptions options):base(options) 
         {
           
         }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.department)
                .WithMany(d => d.employees)
                .HasForeignKey(e => e.departmentId);

            //modelBuilder.Entity<Department>()
            //    .HasMany(d => d.employees)
            //    .WithOne(e=> e.department)
            //    .HasForeignKey(d=>d.departmentId);
                  

        }
    }
}
