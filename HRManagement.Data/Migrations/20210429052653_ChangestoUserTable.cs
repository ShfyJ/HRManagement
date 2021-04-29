using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace HRManagement.Data.Migrations
{
    public partial class ChangestoUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Countries_CountryId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Districts_DistrictId",
                table: "AspNetUsers");


            migrationBuilder.RenameColumn(
                name: "FullAddress",
                table: "AspNetUsers",
                newName: "FullBirthAddress");

            migrationBuilder.RenameColumn(
                name: "DistrictId",
                table: "AspNetUsers",
                newName: "CurrentDistrictId");

            migrationBuilder.RenameColumn(
                name: "CountryId",
                table: "AspNetUsers",
                newName: "CurrentCountryId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_DistrictId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_CurrentDistrictId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_CountryId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_CurrentCountryId");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Languages",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BirthCountryId",
                table: "AspNetUsers",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BirthDistrictId",
                table: "AspNetUsers",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CurrentAddress",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Languages_UserId",
                table: "Languages",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_BirthCountryId",
                table: "AspNetUsers",
                column: "BirthCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_BirthDistrictId",
                table: "AspNetUsers",
                column: "BirthDistrictId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Countries_BirthCountryId",
                table: "AspNetUsers",
                column: "BirthCountryId",
                principalTable: "Countries",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Countries_CurrentCountryId",
                table: "AspNetUsers",
                column: "CurrentCountryId",
                principalTable: "Countries",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Districts_BirthDistrictId",
                table: "AspNetUsers",
                column: "BirthDistrictId",
                principalTable: "Districts",
                principalColumn: "DisrictId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Districts_CurrentDistrictId",
                table: "AspNetUsers",
                column: "CurrentDistrictId",
                principalTable: "Districts",
                principalColumn: "DisrictId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Languages_AspNetUsers_UserId",
                table: "Languages",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Countries_BirthCountryId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Countries_CurrentCountryId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Districts_BirthDistrictId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Districts_CurrentDistrictId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Languages_AspNetUsers_UserId",
                table: "Languages");

            migrationBuilder.DropIndex(
                name: "IX_Languages_UserId",
                table: "Languages");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_BirthCountryId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_BirthDistrictId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "BirthCountryId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BirthDistrictId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CurrentAddress",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "FullBirthAddress",
                table: "AspNetUsers",
                newName: "FullAddress");

            migrationBuilder.RenameColumn(
                name: "CurrentDistrictId",
                table: "AspNetUsers",
                newName: "DistrictId");

            migrationBuilder.RenameColumn(
                name: "CurrentCountryId",
                table: "AspNetUsers",
                newName: "CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_CurrentDistrictId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_DistrictId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_CurrentCountryId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_CountryId");

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Districts",
                type: "integer",
                nullable: false,
                defaultValue: 0);

           

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Countries_CountryId",
                table: "AspNetUsers",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Districts_DistrictId",
                table: "AspNetUsers",
                column: "DistrictId",
                principalTable: "Districts",
                principalColumn: "DisrictId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
