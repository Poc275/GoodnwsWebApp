using Microsoft.EntityFrameworkCore.Migrations;

namespace GoodnwsWebApp.Migrations
{
    public partial class Renamedvotescolumntoflagged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Votes",
                table: "Stories",
                newName: "Flagged");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Flagged",
                table: "Stories",
                newName: "Votes");
        }
    }
}
