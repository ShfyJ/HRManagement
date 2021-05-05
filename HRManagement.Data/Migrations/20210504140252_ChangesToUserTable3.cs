using Microsoft.EntityFrameworkCore.Migrations;

namespace HRManagement.Data.Migrations
{
    public partial class ChangesToUserTable3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DeputyMembershipId",
                table: "AspNetUsers",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DeputyMembershipId",
                table: "AspNetUsers",
                column: "DeputyMembershipId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_DeputyMemberships_DeputyMembershipId",
                table: "AspNetUsers",
                column: "DeputyMembershipId",
                principalTable: "DeputyMemberships",
                principalColumn: "DeputyMembershipId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_DeputyMemberships_DeputyMembershipId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_DeputyMembershipId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DeputyMembershipId",
                table: "AspNetUsers");
        }
    }
}
