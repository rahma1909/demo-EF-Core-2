using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace demo.contexts.Migrations
{
    /// <inheritdoc />
    public partial class OneToOneRelationshipUsingFluentApis : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Employees_ManagerId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_ManagerId",
                table: "Departments");

            migrationBuilder.RenameColumn(
                name: "ManagerId",
                table: "Departments",
                newName: "empId");

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

            migrationBuilder.RenameColumn(
                name: "empId",
                table: "Departments",
                newName: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_ManagerId",
                table: "Departments",
                column: "ManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Employees_ManagerId",
                table: "Departments",
                column: "ManagerId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
