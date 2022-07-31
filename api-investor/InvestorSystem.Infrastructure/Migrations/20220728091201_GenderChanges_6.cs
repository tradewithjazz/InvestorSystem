using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvestorSystem.Infrastructure.Migrations
{
    public partial class GenderChanges_6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 9, 12, 0, 878, DateTimeKind.Utc).AddTicks(5154));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 9, 6, 21, 116, DateTimeKind.Utc).AddTicks(6140));
        }
    }
}
