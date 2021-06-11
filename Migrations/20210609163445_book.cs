using Microsoft.EntityFrameworkCore.Migrations;

namespace MyScriptureJournal.Migrations
{
    public partial class book : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Scripture");

            migrationBuilder.AddColumn<string>(
                name: "Book",
                table: "Scripture",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Book",
                table: "Scripture");

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "Scripture",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
