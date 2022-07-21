using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace InvestorSystem.Infrastructure.Migrations
{
    public partial class _AddedUserSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeatherForecast");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserName = table.Column<string>(type: "text", nullable: false),
                    UserEmail = table.Column<string>(type: "text", nullable: false),
                    DisplayName = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "GenderCD", "Description", "GenderName" },
                values: new object[,]
                {
                    { "F", "Female", "Female" },
                    { "M", "Male", "Male" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "DisplayName", "IsDeleted", "Password", "UserEmail", "UserName" },
                values: new object[] { 1, new DateTime(2022, 7, 20, 8, 39, 1, 608, DateTimeKind.Utc).AddTicks(3037), "Invester System", false, "InvSys@123", "investor@system.com", "Invester System" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "GenderCD",
                keyValue: "F");

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "GenderCD",
                keyValue: "M");

            migrationBuilder.CreateTable(
                name: "WeatherForecast",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Summary = table.Column<string>(type: "text", nullable: true),
                    TemperatureC = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherForecast", x => x.ID);
                });
        }
    }
}
