using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvestorSystem.Infrastructure.Migrations
{
    public partial class PersonDOBChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DOB",
                table: "Person",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 15, 43, 59, 369, DateTimeKind.Utc).AddTicks(1702));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateOnly>(
                name: "DOB",
                table: "Person",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 27, 15, 42, 27, 785, DateTimeKind.Utc).AddTicks(8184));
        }
    }
}
