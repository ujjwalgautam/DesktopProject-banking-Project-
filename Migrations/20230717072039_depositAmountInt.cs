using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesktopProject.Migrations
{
    /// <inheritdoc />
    public partial class depositAmountInt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "DipAmount",
                table: "Deposit",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "DipAmount",
                table: "Deposit",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
