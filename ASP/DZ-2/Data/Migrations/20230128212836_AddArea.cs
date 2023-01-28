using Microsoft.EntityFrameworkCore.Migrations;

namespace DZ_2.Data.Migrations
{
    public partial class AddArea : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Director",
                table: "Sessions",
                newName: "Night");

            migrationBuilder.AddColumn<string>(
                name: "Day",
                table: "Sessions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Morning",
                table: "Sessions",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Day",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "Morning",
                table: "Sessions");

            migrationBuilder.RenameColumn(
                name: "Night",
                table: "Sessions",
                newName: "Director");
        }
    }
}
