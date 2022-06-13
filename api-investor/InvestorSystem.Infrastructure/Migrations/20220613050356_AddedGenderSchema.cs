using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvestorSystem.Infrastructure.Migrations
{
    public partial class AddedGenderSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    GenderCD = table.Column<string>(type: "character varying(1)", maxLength: 1, nullable: false),
                    GenderName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.GenderCD);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Genders");
        }
    }
}
