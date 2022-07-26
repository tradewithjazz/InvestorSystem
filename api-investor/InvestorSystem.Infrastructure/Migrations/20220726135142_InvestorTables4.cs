using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace InvestorSystem.Infrastructure.Migrations
{
    public partial class InvestorTables4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Investor_BankDetails_BankDetailsID1",
                table: "Investor");

            migrationBuilder.DropIndex(
                name: "IX_Investor_BankDetailsID1",
                table: "Investor");

            migrationBuilder.DropColumn(
                name: "BankDetailsID1",
                table: "Investor");

            migrationBuilder.AlterColumn<short>(
                name: "accountTypeID",
                table: "BankDetails",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "ID",
                table: "BankDetails",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.CreateIndex(
                name: "IX_Investor_BankDetailsID",
                table: "Investor",
                column: "BankDetailsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Investor_BankDetails_BankDetailsID",
                table: "Investor",
                column: "BankDetailsID",
                principalTable: "BankDetails",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Investor_BankDetails_BankDetailsID",
                table: "Investor");

            migrationBuilder.DropIndex(
                name: "IX_Investor_BankDetailsID",
                table: "Investor");

            migrationBuilder.AddColumn<int>(
                name: "BankDetailsID1",
                table: "Investor",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "accountTypeID",
                table: "BankDetails",
                type: "integer",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "BankDetails",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.CreateIndex(
                name: "IX_Investor_BankDetailsID1",
                table: "Investor",
                column: "BankDetailsID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Investor_BankDetails_BankDetailsID1",
                table: "Investor",
                column: "BankDetailsID1",
                principalTable: "BankDetails",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
