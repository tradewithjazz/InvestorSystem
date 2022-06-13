using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvestorSystem.Infrastructure.Migrations
{
    public partial class UpdateGenderSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Genders",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Genders");
        }
    }
}
