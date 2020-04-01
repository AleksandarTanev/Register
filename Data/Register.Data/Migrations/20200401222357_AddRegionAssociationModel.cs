using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Register.Data.Migrations
{
    public partial class AddRegionAssociationModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RegionalAssociationId",
                table: "Members",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "RegionalAssociations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    AssociationName = table.Column<string>(nullable: true),
                    Bulstat = table.Column<string>(nullable: true),
                    WorkAddress = table.Column<string>(nullable: true),
                    ContactAddress = table.Column<string>(nullable: true),
                    RegionCode = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    MobilePhone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    BankName = table.Column<string>(nullable: true),
                    BranchName = table.Column<string>(nullable: true),
                    BankAddress = table.Column<string>(nullable: true),
                    BIC = table.Column<string>(nullable: true),
                    IBAN = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegionalAssociations", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Members_RegionalAssociationId",
                table: "Members",
                column: "RegionalAssociationId");

            migrationBuilder.CreateIndex(
                name: "IX_RegionalAssociations_IsDeleted",
                table: "RegionalAssociations",
                column: "IsDeleted");

            migrationBuilder.AddForeignKey(
                name: "FK_Members_RegionalAssociations_RegionalAssociationId",
                table: "Members",
                column: "RegionalAssociationId",
                principalTable: "RegionalAssociations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_RegionalAssociations_RegionalAssociationId",
                table: "Members");

            migrationBuilder.DropTable(
                name: "RegionalAssociations");

            migrationBuilder.DropIndex(
                name: "IX_Members_RegionalAssociationId",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "RegionalAssociationId",
                table: "Members");
        }
    }
}
