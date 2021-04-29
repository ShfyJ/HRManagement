using Microsoft.EntityFrameworkCore.Migrations;

namespace HRManagement.Data.Migrations
{
    public partial class ChangetoUserBusinessTripTableToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserBusinessTrips_AspNetUsers_ApplicationUserId",
                table: "UserBusinessTrips");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "UserBusinessTrips",
                newName: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserBusinessTrips_AspNetUsers_EmployeeId",
                table: "UserBusinessTrips",
                column: "EmployeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserBusinessTrips_AspNetUsers_EmployeeId",
                table: "UserBusinessTrips");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "UserBusinessTrips",
                newName: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserBusinessTrips_AspNetUsers_ApplicationUserId",
                table: "UserBusinessTrips",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
