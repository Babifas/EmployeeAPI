using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeAPI.Migrations
{
    /// <inheritdoc />
    public partial class migration103 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_departmentdeptId",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "departmentdeptId",
                table: "Employees",
                newName: "departmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_departmentdeptId",
                table: "Employees",
                newName: "IX_Employees_departmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_departmentId",
                table: "Employees",
                column: "departmentId",
                principalTable: "Departments",
                principalColumn: "deptId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_departmentId",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "departmentId",
                table: "Employees",
                newName: "departmentdeptId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_departmentId",
                table: "Employees",
                newName: "IX_Employees_departmentdeptId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_departmentdeptId",
                table: "Employees",
                column: "departmentdeptId",
                principalTable: "Departments",
                principalColumn: "deptId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
