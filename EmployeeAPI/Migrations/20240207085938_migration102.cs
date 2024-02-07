using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeAPI.Migrations
{
    /// <inheritdoc />
    public partial class migration102 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Department_departmentdeptId",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Department",
                table: "Department");

            migrationBuilder.RenameTable(
                name: "Department",
                newName: "Departments");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "deptId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_departmentdeptId",
                table: "Employees",
                column: "departmentdeptId",
                principalTable: "Departments",
                principalColumn: "deptId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_departmentdeptId",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "Department");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Department",
                table: "Department",
                column: "deptId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Department_departmentdeptId",
                table: "Employees",
                column: "departmentdeptId",
                principalTable: "Department",
                principalColumn: "deptId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
