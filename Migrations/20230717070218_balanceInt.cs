using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesktopProject.Migrations
{
    /// <inheritdoc />
    public partial class balanceInt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Balance",
                table: "AccountDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Balance",
                table: "AccountDetails",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
