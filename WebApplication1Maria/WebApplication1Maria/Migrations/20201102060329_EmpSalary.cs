using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1Maria.Migrations
{
    public partial class EmpSalary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "EmpSalary",
                table: "Employees",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmpSalary",
                table: "Employees");
        }
    }
}
