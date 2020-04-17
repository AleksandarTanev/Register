using Microsoft.EntityFrameworkCore.Migrations;

namespace Register.Data.Migrations
{
    public partial class AddPlaceOfResidenceToModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlaceOfResidenceId",
                table: "Members",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Members_PlaceOfResidenceId",
                table: "Members",
                column: "PlaceOfResidenceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Members_PlacesOfResidence_PlaceOfResidenceId",
                table: "Members",
                column: "PlaceOfResidenceId",
                principalTable: "PlacesOfResidence",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_PlacesOfResidence_PlaceOfResidenceId",
                table: "Members");

            migrationBuilder.DropIndex(
                name: "IX_Members_PlaceOfResidenceId",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "PlaceOfResidenceId",
                table: "Members");
        }
    }
}
