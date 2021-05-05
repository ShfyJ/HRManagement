using Microsoft.EntityFrameworkCore.Migrations;

namespace HRManagement.Data.Migrations
{
    public partial class NewChangesToStructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Organizations_OrganizationId",
                table: "Sections");

            migrationBuilder.DropIndex(
                name: "IX_Sections_OrganizationId",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "IsDepartmentSection",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "IsIndependentSection",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "OrganizationId",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "IndependentSectionId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Groups",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDepartment",
                table: "Departments",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsIndependentSection",
                table: "Departments",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Groups_DepartmentId",
                table: "Groups",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Departments_DepartmentId",
                table: "Groups",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Departments_DepartmentId",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_Groups_DepartmentId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "IsDepartment",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "IsIndependentSection",
                table: "Departments");

            migrationBuilder.AddColumn<bool>(
                name: "IsDepartmentSection",
                table: "Sections",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsIndependentSection",
                table: "Sections",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "OrganizationId",
                table: "Sections",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IndependentSectionId",
                table: "AspNetUsers",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sections_OrganizationId",
                table: "Sections",
                column: "OrganizationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Organizations_OrganizationId",
                table: "Sections",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "OrganizationId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
