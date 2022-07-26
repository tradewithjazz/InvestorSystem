using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace InvestorSystem.Infrastructure.Migrations
{
    public partial class InvestorTables3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BankDetailsID1",
                table: "Investor",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NomineeID1",
                table: "Investor",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BankDetails",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    bankName = table.Column<string>(type: "text", nullable: false),
                    accountNumber = table.Column<string>(type: "text", nullable: false),
                    accountName = table.Column<string>(type: "text", nullable: false),
                    IFSC = table.Column<string>(type: "text", nullable: false),
                    accountTypeID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankDetails", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Nominee",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Firstname = table.Column<string>(type: "text", nullable: false),
                    Lastname = table.Column<string>(type: "text", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    RelationshipID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nominee", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Investor_BankDetailsID1",
                table: "Investor",
                column: "BankDetailsID1");

            migrationBuilder.CreateIndex(
                name: "IX_Investor_NomineeID1",
                table: "Investor",
                column: "NomineeID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Investor_BankDetails_BankDetailsID1",
                table: "Investor",
                column: "BankDetailsID1",
                principalTable: "BankDetails",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Investor_Nominee_NomineeID1",
                table: "Investor",
                column: "NomineeID1",
                principalTable: "Nominee",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Investor_BankDetails_BankDetailsID1",
                table: "Investor");

            migrationBuilder.DropForeignKey(
                name: "FK_Investor_Nominee_NomineeID1",
                table: "Investor");

            migrationBuilder.DropTable(
                name: "BankDetails");

            migrationBuilder.DropTable(
                name: "Nominee");

            migrationBuilder.DropIndex(
                name: "IX_Investor_BankDetailsID1",
                table: "Investor");

            migrationBuilder.DropIndex(
                name: "IX_Investor_NomineeID1",
                table: "Investor");

            migrationBuilder.DropColumn(
                name: "BankDetailsID1",
                table: "Investor");

            migrationBuilder.DropColumn(
                name: "NomineeID1",
                table: "Investor");
        }
    }
}
