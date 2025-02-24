using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace demo.contexts.Migrations
{
    /// <inheritdoc />
    public partial class OneToManyRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Employees_empId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_empId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "empId",
                table: "Departments");

            migrationBuilder.AddColumn<int>(
                name: "workforID",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_workforID",
                table: "Employees",
                column: "workforID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_workforID",
                table: "Employees",
                column: "workforID",
                principalTable: "Departments",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_workforID",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_workforID",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "workforID",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "empId",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_empId",
                table: "Departments",
                column: "empId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Employees_empId",
                table: "Departments",
                column: "empId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
