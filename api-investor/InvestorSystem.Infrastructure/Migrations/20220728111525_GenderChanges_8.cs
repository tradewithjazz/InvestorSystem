using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace InvestorSystem.Infrastructure.Migrations
{
    public partial class GenderChanges_8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankDetails_AccountType_AccounttypeID",
                table: "BankDetails");

            migrationBuilder.DropColumn(
                name: "AccountTypeID",
                table: "BankDetails");

            migrationBuilder.RenameColumn(
                name: "AccounttypeID",
                table: "BankDetails",
                newName: "AccountTypeID");

            migrationBuilder.RenameIndex(
                name: "IX_BankDetails_AccounttypeID",
                table: "BankDetails",
                newName: "IX_BankDetails_AccountTypeID");

            migrationBuilder.AlterColumn<short>(
                name: "AccountTypeID",
                table: "BankDetails",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "ID",
                table: "AccountType",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 11, 15, 25, 177, DateTimeKind.Utc).AddTicks(7519));

            migrationBuilder.AddForeignKey(
                name: "FK_BankDetails_AccountType_AccountTypeID",
                table: "BankDetails",
                column: "AccountTypeID",
                principalTable: "AccountType",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankDetails_AccountType_AccountTypeID",
                table: "BankDetails");

            migrationBuilder.RenameColumn(
                name: "AccountTypeID",
                table: "BankDetails",
                newName: "AccounttypeID");

            migrationBuilder.RenameIndex(
                name: "IX_BankDetails_AccountTypeID",
                table: "BankDetails",
                newName: "IX_BankDetails_AccounttypeID");

            migrationBuilder.AlterColumn<int>(
                name: "AccounttypeID",
                table: "BankDetails",
                type: "integer",
                nullable: true,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AddColumn<short>(
                name: "AccountTypeID",
                table: "BankDetails",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "AccountType",
                type: "integer",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 9, 14, 19, 678, DateTimeKind.Utc).AddTicks(40));

            migrationBuilder.AddForeignKey(
                name: "FK_BankDetails_AccountType_AccounttypeID",
                table: "BankDetails",
                column: "AccounttypeID",
                principalTable: "AccountType",
                principalColumn: "ID");
        }
    }
}
