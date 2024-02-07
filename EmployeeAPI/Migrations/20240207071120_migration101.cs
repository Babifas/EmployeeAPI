using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeAPI.Migrations
{
    /// <inheritdoc />
    public partial class migration101 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "departmentdeptId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    deptId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.deptId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_departmentdeptId",
                table: "Employees",
                column: "departmentdeptId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Department_departmentdeptId",
                table: "Employees",
                column: "departmentdeptId",
                principalTable: "Department",
                principalColumn: "deptId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Department_departmentdeptId",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropIndex(
                name: "IX_Employees_departmentdeptId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "departmentdeptId",
                table: "Employees");
        }
    }
}
