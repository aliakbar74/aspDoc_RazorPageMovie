using Microsoft.EntityFrameworkCore.Migrations;

namespace aspDoc_RazorPageMovie.Migrations
{
    public partial class makeBookNotNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Book",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Book",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
