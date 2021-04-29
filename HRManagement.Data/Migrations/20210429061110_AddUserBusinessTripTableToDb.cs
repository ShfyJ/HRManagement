using Microsoft.EntityFrameworkCore.Migrations;

namespace HRManagement.Data.Migrations
{
    public partial class AddUserBusinessTripTableToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BusinessTrips_AspNetUsers_EmployeeId",
                table: "BusinessTrips");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessTrips_AspNetUsers_SubstituteEmployeeId",
                table: "BusinessTrips");

            migrationBuilder.DropIndex(
                name: "IX_BusinessTrips_EmployeeId",
                table: "BusinessTrips");

            migrationBuilder.DropIndex(
                name: "IX_BusinessTrips_SubstituteEmployeeId",
                table: "BusinessTrips");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "BusinessTrips");

            migrationBuilder.DropColumn(
                name: "SubstituteEmployeeId",
                table: "BusinessTrips");

            migrationBuilder.CreateTable(
                name: "UserBusinessTrips",
                columns: table => new
                {
                    ApplicationUserId = table.Column<string>(type: "text", nullable: false),
                    BusinessTripId = table.Column<int>(type: "integer", nullable: false),
                    IsSubstitute = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBusinessTrips", x => new { x.ApplicationUserId, x.BusinessTripId });
                    table.ForeignKey(
                        name: "FK_UserBusinessTrips_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserBusinessTrips_BusinessTrips_BusinessTripId",
                        column: x => x.BusinessTripId,
                        principalTable: "BusinessTrips",
                        principalColumn: "BusinessTripId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserBusinessTrips_BusinessTripId",
                table: "UserBusinessTrips",
                column: "BusinessTripId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserBusinessTrips");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeId",
                table: "BusinessTrips",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubstituteEmployeeId",
                table: "BusinessTrips",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTrips_EmployeeId",
                table: "BusinessTrips",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTrips_SubstituteEmployeeId",
                table: "BusinessTrips",
                column: "SubstituteEmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessTrips_AspNetUsers_EmployeeId",
                table: "BusinessTrips",
                column: "EmployeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessTrips_AspNetUsers_SubstituteEmployeeId",
                table: "BusinessTrips",
                column: "SubstituteEmployeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
