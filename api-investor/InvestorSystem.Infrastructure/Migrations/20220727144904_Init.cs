using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace InvestorSystem.Infrastructure.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountType",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountType", x => x.ID);
                });

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
                name: "MaritalStatuse",
                columns: table => new
                {
                    ID = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaritalStatuse", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Relationship",
                columns: table => new
                {
                    ID = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relationship", x => x.ID);
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

            migrationBuilder.CreateTable(
                name: "BankDetails",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BankName = table.Column<string>(type: "text", nullable: false),
                    AccountNumber = table.Column<string>(type: "text", nullable: false),
                    AccountName = table.Column<string>(type: "text", nullable: false),
                    IFSC = table.Column<string>(type: "text", nullable: false),
                    AccountTypeID = table.Column<short>(type: "smallint", nullable: false),
                    AccounttypeID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BankDetails_AccountType_AccounttypeID",
                        column: x => x.AccounttypeID,
                        principalTable: "AccountType",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    AddressLine1 = table.Column<string>(type: "text", nullable: false),
                    AddressLine2 = table.Column<string>(type: "text", nullable: false),
                    DOB = table.Column<DateOnly>(type: "date", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    MobileNo = table.Column<string>(type: "text", nullable: false),
                    AlternateMobileNo = table.Column<string>(type: "text", nullable: false),
                    MaritalStatusID = table.Column<short>(type: "smallint", nullable: true),
                    Gender = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Person_MaritalStatuse_MaritalStatusID",
                        column: x => x.MaritalStatusID,
                        principalTable: "MaritalStatuse",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Nominee",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Firstname = table.Column<string>(type: "text", nullable: false),
                    Lastname = table.Column<string>(type: "text", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    RelationshipID = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nominee", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Nominee_Relationship_RelationshipID",
                        column: x => x.RelationshipID,
                        principalTable: "Relationship",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
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
                    table.PrimaryKey("PK_Employee", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Employee_BankDetails_BankDetailsID",
                        column: x => x.BankDetailsID,
                        principalTable: "BankDetails",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_Nominee_NomineeID",
                        column: x => x.NomineeID,
                        principalTable: "Nominee",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_Person_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Person",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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
                        name: "FK_Investor_BankDetails_BankDetailsID",
                        column: x => x.BankDetailsID,
                        principalTable: "BankDetails",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Investor_Nominee_NomineeID",
                        column: x => x.NomineeID,
                        principalTable: "Nominee",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Investor_Person_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Person",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employee_Comp_History",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Amount = table.Column<long>(type: "bigint", nullable: false),
                    EmployeeID = table.Column<long>(type: "bigint", nullable: false),
                    CredOrDebID = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_Comp_History", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Employee_Comp_History_CredOrDeb_CredOrDebID",
                        column: x => x.CredOrDebID,
                        principalTable: "CredOrDeb",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_Comp_History_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employee_Comp_Intermediate",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmployeeID = table.Column<long>(type: "bigint", nullable: false),
                    Amount = table.Column<long>(type: "bigint", nullable: false),
                    AsOfDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_Comp_Intermediate", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Employee_Comp_Intermediate_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employee_Comp_Investment",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmployeeID = table.Column<long>(type: "bigint", nullable: false),
                    Amount = table.Column<long>(type: "bigint", nullable: false),
                    LastModified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_Comp_Investment", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Employee_Comp_Investment_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employee_Payment_History",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Amount = table.Column<long>(type: "bigint", nullable: false),
                    EmployeeID = table.Column<long>(type: "bigint", nullable: false),
                    CredOrDebID = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_Payment_History", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Employee_Payment_History_CredOrDeb_CredOrDebID",
                        column: x => x.CredOrDebID,
                        principalTable: "CredOrDeb",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_Payment_History_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employee_Payout_History",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Amount = table.Column<long>(type: "bigint", nullable: false),
                    EmployeeID = table.Column<long>(type: "bigint", nullable: false),
                    PaidOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_Payout_History", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Employee_Payout_History_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employee_Payout_Intermediate",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmployeeID = table.Column<long>(type: "bigint", nullable: false),
                    Amount = table.Column<long>(type: "bigint", nullable: false),
                    ForDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_Payout_Intermediate", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Employee_Payout_Intermediate_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employee_Payout_Investment",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmployeeID = table.Column<long>(type: "bigint", nullable: false),
                    Amount = table.Column<long>(type: "bigint", nullable: false),
                    LastModified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_Payout_Investment", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Employee_Payout_Investment_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "DisplayName", "IsDeleted", "Password", "UserEmail", "UserName" },
                values: new object[] { 1, new DateTime(2022, 7, 27, 14, 49, 4, 828, DateTimeKind.Utc).AddTicks(4138), "Invester System", false, "InvSys@123", "investor@system.com", "Invester System" });

            migrationBuilder.CreateIndex(
                name: "IX_BankDetails_AccounttypeID",
                table: "BankDetails",
                column: "AccounttypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_BankDetailsID",
                table: "Employee",
                column: "BankDetailsID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_NomineeID",
                table: "Employee",
                column: "NomineeID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_PersonID",
                table: "Employee",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Comp_History_CredOrDebID",
                table: "Employee_Comp_History",
                column: "CredOrDebID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Comp_History_EmployeeID",
                table: "Employee_Comp_History",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Comp_Intermediate_EmployeeID",
                table: "Employee_Comp_Intermediate",
                column: "EmployeeID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Comp_Investment_EmployeeID",
                table: "Employee_Comp_Investment",
                column: "EmployeeID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Payment_History_CredOrDebID",
                table: "Employee_Payment_History",
                column: "CredOrDebID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Payment_History_EmployeeID",
                table: "Employee_Payment_History",
                column: "EmployeeID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Payout_History_EmployeeID",
                table: "Employee_Payout_History",
                column: "EmployeeID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Payout_Intermediate_EmployeeID",
                table: "Employee_Payout_Intermediate",
                column: "EmployeeID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Payout_Investment_EmployeeID",
                table: "Employee_Payout_Investment",
                column: "EmployeeID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Investor_BankDetailsID",
                table: "Investor",
                column: "BankDetailsID");

            migrationBuilder.CreateIndex(
                name: "IX_Investor_NomineeID",
                table: "Investor",
                column: "NomineeID");

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

            migrationBuilder.CreateIndex(
                name: "IX_Nominee_RelationshipID",
                table: "Nominee",
                column: "RelationshipID");

            migrationBuilder.CreateIndex(
                name: "IX_Person_MaritalStatusID",
                table: "Person",
                column: "MaritalStatusID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee_Comp_History");

            migrationBuilder.DropTable(
                name: "Employee_Comp_Intermediate");

            migrationBuilder.DropTable(
                name: "Employee_Comp_Investment");

            migrationBuilder.DropTable(
                name: "Employee_Payment_History");

            migrationBuilder.DropTable(
                name: "Employee_Payout_History");

            migrationBuilder.DropTable(
                name: "Employee_Payout_Intermediate");

            migrationBuilder.DropTable(
                name: "Employee_Payout_Investment");

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
                name: "Users");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "CredOrDeb");

            migrationBuilder.DropTable(
                name: "Investor");

            migrationBuilder.DropTable(
                name: "BankDetails");

            migrationBuilder.DropTable(
                name: "Nominee");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "AccountType");

            migrationBuilder.DropTable(
                name: "Relationship");

            migrationBuilder.DropTable(
                name: "MaritalStatuse");
        }
    }
}
