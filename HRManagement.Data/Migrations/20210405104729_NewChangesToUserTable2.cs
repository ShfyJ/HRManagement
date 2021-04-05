using Microsoft.EntityFrameworkCore.Migrations;

namespace HRManagement.Data.Migrations
{
    public partial class NewChangesToUserTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Disabilities_DisabilityId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_EdInformations_EdInformationId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_MilitaryServiceStatuses_MilitaryServiceStatusId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_MilitaryTitles_MilitaryTitleId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Nationalities_NationalityId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Partisanships_PartisanshipId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Passports_PassportId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Positions_PositionId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_ScienceDegrees_ScienceDegreeId",
                table: "AspNetUsers");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Disabilities_DisabilityId",
                table: "AspNetUsers",
                column: "DisabilityId",
                principalTable: "Disabilities",
                principalColumn: "DisabilityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_EdInformations_EdInformationId",
                table: "AspNetUsers",
                column: "EdInformationId",
                principalTable: "EdInformations",
                principalColumn: "EdInformationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_MilitaryServiceStatuses_MilitaryServiceStatusId",
                table: "AspNetUsers",
                column: "MilitaryServiceStatusId",
                principalTable: "MilitaryServiceStatuses",
                principalColumn: "MilitaryServiceStatusId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_MilitaryTitles_MilitaryTitleId",
                table: "AspNetUsers",
                column: "MilitaryTitleId",
                principalTable: "MilitaryTitles",
                principalColumn: "MilitaryTitleId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Nationalities_NationalityId",
                table: "AspNetUsers",
                column: "NationalityId",
                principalTable: "Nationalities",
                principalColumn: "NationalityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Partisanships_PartisanshipId",
                table: "AspNetUsers",
                column: "PartisanshipId",
                principalTable: "Partisanships",
                principalColumn: "PartisanshipId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Passports_PassportId",
                table: "AspNetUsers",
                column: "PassportId",
                principalTable: "Passports",
                principalColumn: "PassportId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Positions_PositionId",
                table: "AspNetUsers",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "PositionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_ScienceDegrees_ScienceDegreeId",
                table: "AspNetUsers",
                column: "ScienceDegreeId",
                principalTable: "ScienceDegrees",
                principalColumn: "ScienceDegreeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Disabilities_DisabilityId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_EdInformations_EdInformationId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_MilitaryServiceStatuses_MilitaryServiceStatusId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_MilitaryTitles_MilitaryTitleId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Nationalities_NationalityId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Partisanships_PartisanshipId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Passports_PassportId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Positions_PositionId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_ScienceDegrees_ScienceDegreeId",
                table: "AspNetUsers");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Disabilities_DisabilityId",
                table: "AspNetUsers",
                column: "DisabilityId",
                principalTable: "Disabilities",
                principalColumn: "DisabilityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_EdInformations_EdInformationId",
                table: "AspNetUsers",
                column: "EdInformationId",
                principalTable: "EdInformations",
                principalColumn: "EdInformationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_MilitaryServiceStatuses_MilitaryServiceStatusId",
                table: "AspNetUsers",
                column: "MilitaryServiceStatusId",
                principalTable: "MilitaryServiceStatuses",
                principalColumn: "MilitaryServiceStatusId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_MilitaryTitles_MilitaryTitleId",
                table: "AspNetUsers",
                column: "MilitaryTitleId",
                principalTable: "MilitaryTitles",
                principalColumn: "MilitaryTitleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Nationalities_NationalityId",
                table: "AspNetUsers",
                column: "NationalityId",
                principalTable: "Nationalities",
                principalColumn: "NationalityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Partisanships_PartisanshipId",
                table: "AspNetUsers",
                column: "PartisanshipId",
                principalTable: "Partisanships",
                principalColumn: "PartisanshipId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Passports_PassportId",
                table: "AspNetUsers",
                column: "PassportId",
                principalTable: "Passports",
                principalColumn: "PassportId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Positions_PositionId",
                table: "AspNetUsers",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "PositionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_ScienceDegrees_ScienceDegreeId",
                table: "AspNetUsers",
                column: "ScienceDegreeId",
                principalTable: "ScienceDegrees",
                principalColumn: "ScienceDegreeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
