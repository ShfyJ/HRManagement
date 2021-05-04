using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace HRManagement.Data.Migrations
{
    public partial class ChangesToOrgStucture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_IndependentSections_IndependentSectionId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Sections_SectionId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacancies_IndependentSections_IndependentSectionId",
                table: "Vacancies");

            migrationBuilder.DropTable(
                name: "IndependentSections");

            migrationBuilder.DropIndex(
                name: "IX_Vacancies_IndependentSectionId",
                table: "Vacancies");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_IndependentSectionId",
                table: "AspNetUsers");

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

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Sections",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "SectionId",
                table: "Groups",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Groups",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Departments",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "BirthRegionId",
                table: "AspNetUsers",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CurrentRegionId",
                table: "AspNetUsers",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DeputyMemberships",
                columns: table => new
                {
                    DeputyMembershipId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DeputyMembershipName = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeputyMemberships", x => x.DeputyMembershipId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sections_OrganizationId",
                table: "Sections",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_BirthRegionId",
                table: "AspNetUsers",
                column: "BirthRegionId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CurrentRegionId",
                table: "AspNetUsers",
                column: "CurrentRegionId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Regions_BirthRegionId",
                table: "AspNetUsers",
                column: "BirthRegionId",
                principalTable: "Regions",
                principalColumn: "RegionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Regions_CurrentRegionId",
                table: "AspNetUsers",
                column: "CurrentRegionId",
                principalTable: "Regions",
                principalColumn: "RegionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Sections_SectionId",
                table: "Groups",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "SectionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Organizations_OrganizationId",
                table: "Sections",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "OrganizationId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Regions_BirthRegionId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Regions_CurrentRegionId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Sections_SectionId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Organizations_OrganizationId",
                table: "Sections");

            migrationBuilder.DropTable(
                name: "DeputyMemberships");

            migrationBuilder.DropIndex(
                name: "IX_Sections_OrganizationId",
                table: "Sections");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_BirthRegionId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CurrentRegionId",
                table: "AspNetUsers");

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
                name: "Status",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "BirthRegionId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CurrentRegionId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "SectionId",
                table: "Groups",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "IndependentSections",
                columns: table => new
                {
                    IndependentSectionId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IndependentSectionName = table.Column<string>(type: "text", nullable: true),
                    OrganizationId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndependentSections", x => x.IndependentSectionId);
                    table.ForeignKey(
                        name: "FK_IndependentSections_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "OrganizationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vacancies_IndependentSectionId",
                table: "Vacancies",
                column: "IndependentSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_IndependentSectionId",
                table: "AspNetUsers",
                column: "IndependentSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_IndependentSections_OrganizationId",
                table: "IndependentSections",
                column: "OrganizationId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_IndependentSections_IndependentSectionId",
                table: "AspNetUsers",
                column: "IndependentSectionId",
                principalTable: "IndependentSections",
                principalColumn: "IndependentSectionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Sections_SectionId",
                table: "Groups",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "SectionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancies_IndependentSections_IndependentSectionId",
                table: "Vacancies",
                column: "IndependentSectionId",
                principalTable: "IndependentSections",
                principalColumn: "IndependentSectionId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
