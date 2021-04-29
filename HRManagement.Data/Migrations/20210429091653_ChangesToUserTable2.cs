using Microsoft.EntityFrameworkCore.Migrations;

namespace HRManagement.Data.Migrations
{
    public partial class ChangesToUserTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_EdInformations_EdInformationId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_ScienceDegrees_ScienceDegreeId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_EdInformationId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ScienceDegreeId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EdInformationId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ScienceDegreeId",
                table: "AspNetUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EdInformationId",
                table: "AspNetUsers",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ScienceDegreeId",
                table: "AspNetUsers",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_EdInformationId",
                table: "AspNetUsers",
                column: "EdInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ScienceDegreeId",
                table: "AspNetUsers",
                column: "ScienceDegreeId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_EdInformations_EdInformationId",
                table: "AspNetUsers",
                column: "EdInformationId",
                principalTable: "EdInformations",
                principalColumn: "EdInformationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_ScienceDegrees_ScienceDegreeId",
                table: "AspNetUsers",
                column: "ScienceDegreeId",
                principalTable: "ScienceDegrees",
                principalColumn: "ScienceDegreeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
