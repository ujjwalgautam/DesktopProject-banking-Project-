using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesktopProject.Migrations
{
    /// <inheritdoc />
    public partial class AccountNAmeDataType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "AccountNo",
                table: "Deposit",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AccountNo",
                table: "Deposit",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
