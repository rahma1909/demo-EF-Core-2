using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace demo.contexts.Migrations
{
    /// <inheritdoc />
    public partial class OneToManyRelationshipWithFluentApis : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
