using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesktopProject.Migrations
{
    /// <inheritdoc />
    public partial class Transfer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ToTransfer",
                table: "Transfer",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "Balance",
                table: "Transfer",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<int>(
                name: "TAmountt",
                table: "Transfer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "DebAmount",
                table: "Debit",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "AccountNo",
                table: "Debit",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TAmountt",
                table: "Transfer");

            migrationBuilder.AlterColumn<decimal>(
                name: "ToTransfer",
                table: "Transfer",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "Balance",
                table: "Transfer",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "DebAmount",
                table: "Debit",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "AccountNo",
                table: "Debit",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
