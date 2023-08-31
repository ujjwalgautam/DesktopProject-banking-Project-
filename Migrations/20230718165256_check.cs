using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesktopProject.Migrations
{
    /// <inheritdoc />
    public partial class check : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Balance",
                table: "Transfer");

            migrationBuilder.AddColumn<string>(
                name: "ToName",
                table: "Transfer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ToName",
                table: "Transfer");

            migrationBuilder.AddColumn<int>(
                name: "Balance",
                table: "Transfer",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
