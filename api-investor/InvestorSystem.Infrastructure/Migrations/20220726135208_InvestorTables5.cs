using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace InvestorSystem.Infrastructure.Migrations
{
    public partial class InvestorTables5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Investor_Nominee_NomineeID1",
                table: "Investor");

            migrationBuilder.DropIndex(
                name: "IX_Investor_NomineeID1",
                table: "Investor");

            migrationBuilder.DropColumn(
                name: "NomineeID1",
                table: "Investor");

            migrationBuilder.AlterColumn<long>(
                name: "ID",
                table: "Nominee",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.CreateIndex(
                name: "IX_Investor_NomineeID",
                table: "Investor",
                column: "NomineeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Investor_Nominee_NomineeID",
                table: "Investor",
                column: "NomineeID",
                principalTable: "Nominee",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Investor_Nominee_NomineeID",
                table: "Investor");

            migrationBuilder.DropIndex(
                name: "IX_Investor_NomineeID",
                table: "Investor");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "Nominee",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "NomineeID1",
                table: "Investor",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Investor_NomineeID1",
                table: "Investor",
                column: "NomineeID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Investor_Nominee_NomineeID1",
                table: "Investor",
                column: "NomineeID1",
                principalTable: "Nominee",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
