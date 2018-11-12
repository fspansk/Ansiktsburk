using Microsoft.EntityFrameworkCore.Migrations;

namespace Ansiktsburk.Migrations
{
    public partial class ChangesToCapitalLettersInModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "timestamp",
                table: "Posts",
                newName: "Timestamp");

            migrationBuilder.RenameColumn(
                name: "body",
                table: "Posts",
                newName: "Body");

            migrationBuilder.RenameColumn(
                name: "author",
                table: "Posts",
                newName: "Author");

            migrationBuilder.AlterColumn<string>(
                name: "Author",
                table: "Posts",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Timestamp",
                table: "Posts",
                newName: "timestamp");

            migrationBuilder.RenameColumn(
                name: "Body",
                table: "Posts",
                newName: "body");

            migrationBuilder.RenameColumn(
                name: "Author",
                table: "Posts",
                newName: "author");

            migrationBuilder.AlterColumn<string>(
                name: "author",
                table: "Posts",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
