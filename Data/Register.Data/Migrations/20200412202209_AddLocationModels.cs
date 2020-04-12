using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Register.Data.Migrations
{
    public partial class AddLocationModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RegionalAssociationId",
                table: "Members",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    RegionName = table.Column<string>(nullable: true),
                    RegionEmail = table.Column<string>(nullable: true),
                    RegionCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Municipalities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    NhifCode = table.Column<string>(nullable: true),
                    MunicipalityName = table.Column<string>(nullable: true),
                    RegionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipalities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Municipalities_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PlacesOfResidence",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    UprcCode = table.Column<int>(nullable: false),
                    PlaceOfResidenceName = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true),
                    PhoneCode = table.Column<string>(nullable: true),
                    PlaceOfResidenceType = table.Column<string>(nullable: true),
                    MunicipalityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlacesOfResidence", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlacesOfResidence_Municipalities_MunicipalityId",
                        column: x => x.MunicipalityId,
                        principalTable: "Municipalities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Municipalities_IsDeleted",
                table: "Municipalities",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Municipalities_RegionId",
                table: "Municipalities",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_PlacesOfResidence_IsDeleted",
                table: "PlacesOfResidence",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_PlacesOfResidence_MunicipalityId",
                table: "PlacesOfResidence",
                column: "MunicipalityId");

            migrationBuilder.CreateIndex(
                name: "IX_Regions_IsDeleted",
                table: "Regions",
                column: "IsDeleted");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlacesOfResidence");

            migrationBuilder.DropTable(
                name: "Municipalities");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.AlterColumn<int>(
                name: "RegionalAssociationId",
                table: "Members",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
