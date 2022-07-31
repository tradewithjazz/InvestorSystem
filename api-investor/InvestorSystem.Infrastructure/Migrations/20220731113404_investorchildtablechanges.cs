using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvestorSystem.Infrastructure.Migrations
{
    public partial class investorchildtablechanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 31, 11, 34, 3, 869, DateTimeKind.Utc).AddTicks(2200));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 31, 11, 30, 1, 740, DateTimeKind.Utc).AddTicks(8286));
        }
    }
}
