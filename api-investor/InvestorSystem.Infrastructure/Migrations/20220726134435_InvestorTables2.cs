using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace InvestorSystem.Infrastructure.Migrations
{
    public partial class InvestorTables2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CredOrDeb",
                columns: table => new
                {
                    ID = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CredOrDeb", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", maxLength: 1, nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    firstName = table.Column<string>(type: "text", nullable: false),
                    lastName = table.Column<string>(type: "text", nullable: false),
                    addressLine1 = table.Column<string>(type: "text", nullable: false),
                    addressLine2 = table.Column<string>(type: "text", nullable: false),
                    dob = table.Column<DateOnly>(type: "date", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    districtID = table.Column<int>(type: "integer", nullable: false),
                    mobileNo = table.Column<string>(type: "text", nullable: false),
                    alternateMobileNo = table.Column<string>(type: "text", nullable: false),
                    maritalStatusID = table.Column<short>(type: "smallint", nullable: false),
                    genderID = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TransactionType",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WeatherForecast",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    TemperatureC = table.Column<int>(type: "integer", nullable: false),
                    Summary = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherForecast", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Investor",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonID = table.Column<long>(type: "bigint", nullable: false),
                    BankDetailsID = table.Column<long>(type: "bigint", nullable: false),
                    NomineeID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Investor", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Investor_Person_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Person",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Investor_Comp_History",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Amount = table.Column<long>(type: "bigint", nullable: false),
                    InvestorID = table.Column<long>(type: "bigint", nullable: false),
                    CredOrDebID = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Investor_Comp_History", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Investor_Comp_History_CredOrDeb_CredOrDebID",
                        column: x => x.CredOrDebID,
                        principalTable: "CredOrDeb",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Investor_Comp_History_Investor_InvestorID",
                        column: x => x.InvestorID,
                        principalTable: "Investor",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Investor_Comp_Intermediate",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    InvestorID = table.Column<long>(type: "bigint", nullable: false),
                    Amount = table.Column<long>(type: "bigint", nullable: false),
                    AsOfDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Investor_Comp_Intermediate", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Investor_Comp_Intermediate_Investor_InvestorID",
                        column: x => x.InvestorID,
                        principalTable: "Investor",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Investor_Comp_Investment",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    InvestorID = table.Column<long>(type: "bigint", nullable: false),
                    Amount = table.Column<long>(type: "bigint", nullable: false),
                    LastModified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Investor_Comp_Investment", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Investor_Comp_Investment_Investor_InvestorID",
                        column: x => x.InvestorID,
                        principalTable: "Investor",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Investor_Payment_History",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    InvestorID = table.Column<long>(type: "bigint", nullable: false),
                    Amount = table.Column<long>(type: "bigint", nullable: false),
                    CredOrDebID = table.Column<short>(type: "smallint", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Investor_Payment_History", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Investor_Payment_History_CredOrDeb_CredOrDebID",
                        column: x => x.CredOrDebID,
                        principalTable: "CredOrDeb",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Investor_Payment_History_Investor_InvestorID",
                        column: x => x.InvestorID,
                        principalTable: "Investor",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Investor_Payout_History",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Amount = table.Column<long>(type: "bigint", nullable: false),
                    InvestorID = table.Column<long>(type: "bigint", nullable: false),
                    PaidOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Investor_Payout_History", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Investor_Payout_History_Investor_InvestorID",
                        column: x => x.InvestorID,
                        principalTable: "Investor",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Investor_Payout_Intermediate",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    InvestorID = table.Column<long>(type: "bigint", nullable: false),
                    Amount = table.Column<long>(type: "bigint", nullable: false),
                    ForDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Investor_Payout_Intermediate", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Investor_Payout_Intermediate_Investor_InvestorID",
                        column: x => x.InvestorID,
                        principalTable: "Investor",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Investor_Payout_Investment",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    InvestorID = table.Column<long>(type: "bigint", nullable: false),
                    Amount = table.Column<long>(type: "bigint", nullable: false),
                    LastModified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Investor_Payout_Investment", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Investor_Payout_Investment_Investor_InvestorID",
                        column: x => x.InvestorID,
                        principalTable: "Investor",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Gender",
                columns: new[] { "ID", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Male", "Male" },
                    { 2, "Female", "Female" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Investor_PersonID",
                table: "Investor",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Investor_Comp_History_CredOrDebID",
                table: "Investor_Comp_History",
                column: "CredOrDebID");

            migrationBuilder.CreateIndex(
                name: "IX_Investor_Comp_History_InvestorID",
                table: "Investor_Comp_History",
                column: "InvestorID");

            migrationBuilder.CreateIndex(
                name: "IX_Investor_Comp_Intermediate_InvestorID",
                table: "Investor_Comp_Intermediate",
                column: "InvestorID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Investor_Comp_Investment_InvestorID",
                table: "Investor_Comp_Investment",
                column: "InvestorID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Investor_Payment_History_CredOrDebID",
                table: "Investor_Payment_History",
                column: "CredOrDebID");

            migrationBuilder.CreateIndex(
                name: "IX_Investor_Payment_History_InvestorID",
                table: "Investor_Payment_History",
                column: "InvestorID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Investor_Payout_History_InvestorID",
                table: "Investor_Payout_History",
                column: "InvestorID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Investor_Payout_Intermediate_InvestorID",
                table: "Investor_Payout_Intermediate",
                column: "InvestorID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Investor_Payout_Investment_InvestorID",
                table: "Investor_Payout_Investment",
                column: "InvestorID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "Investor_Comp_History");

            migrationBuilder.DropTable(
                name: "Investor_Comp_Intermediate");

            migrationBuilder.DropTable(
                name: "Investor_Comp_Investment");

            migrationBuilder.DropTable(
                name: "Investor_Payment_History");

            migrationBuilder.DropTable(
                name: "Investor_Payout_History");

            migrationBuilder.DropTable(
                name: "Investor_Payout_Intermediate");

            migrationBuilder.DropTable(
                name: "Investor_Payout_Investment");

            migrationBuilder.DropTable(
                name: "TransactionType");

            migrationBuilder.DropTable(
                name: "WeatherForecast");

            migrationBuilder.DropTable(
                name: "CredOrDeb");

            migrationBuilder.DropTable(
                name: "Investor");

            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
