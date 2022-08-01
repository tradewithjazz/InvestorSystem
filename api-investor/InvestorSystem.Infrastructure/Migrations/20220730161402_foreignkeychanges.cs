using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvestorSystem.Infrastructure.Migrations
{
    public partial class foreignkeychanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankDetails_AccountType_AccountTypeID",
                table: "BankDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Investor_BankDetails_BankDetailsID",
                table: "Investor");

            migrationBuilder.DropForeignKey(
                name: "FK_Investor_Nominee_NomineeID",
                table: "Investor");

            migrationBuilder.DropForeignKey(
                name: "FK_Investor_Person_PersonID",
                table: "Investor");

            migrationBuilder.DropForeignKey(
                name: "FK_Investor_Comp_History_CredOrDeb_CredOrDebID",
                table: "Investor_Comp_History");

            migrationBuilder.DropForeignKey(
                name: "FK_Investor_Comp_History_Investor_InvestorID",
                table: "Investor_Comp_History");

            migrationBuilder.DropForeignKey(
                name: "FK_Investor_Comp_Intermediate_Investor_InvestorID",
                table: "Investor_Comp_Intermediate");

            migrationBuilder.DropForeignKey(
                name: "FK_Investor_Comp_Investment_Investor_InvestorID",
                table: "Investor_Comp_Investment");

            migrationBuilder.DropForeignKey(
                name: "FK_Investor_Payment_History_CredOrDeb_CredOrDebID",
                table: "Investor_Payment_History");

            migrationBuilder.DropForeignKey(
                name: "FK_Investor_Payment_History_Investor_InvestorID",
                table: "Investor_Payment_History");

            migrationBuilder.DropForeignKey(
                name: "FK_Investor_Payout_History_Investor_InvestorID",
                table: "Investor_Payout_History");

            migrationBuilder.DropForeignKey(
                name: "FK_Investor_Payout_Intermediate_Investor_InvestorID",
                table: "Investor_Payout_Intermediate");

            migrationBuilder.DropForeignKey(
                name: "FK_Investor_Payout_Investment_Investor_InvestorID",
                table: "Investor_Payout_Investment");

            migrationBuilder.DropForeignKey(
                name: "FK_Nominee_Relationship_RelationshipID",
                table: "Nominee");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Person_Gender_GenderID",
            //    table: "Person");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Person_MaritalStatuse_MaritalStatusID",
            //    table: "Person");

            migrationBuilder.AlterColumn<short>(
                name: "MaritalStatusID",
                table: "Person",
                type: "smallint",
                nullable: true,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<short>(
                name: "GenderID",
                table: "Person",
                type: "smallint",
                nullable: true,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<short>(
                name: "RelationshipID",
                table: "Nominee",
                type: "smallint",
                nullable: true,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<long>(
                name: "InvestorID",
                table: "Investor_Payout_Investment",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "InvestorID",
                table: "Investor_Payout_Intermediate",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "InvestorID",
                table: "Investor_Payout_History",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "InvestorID",
                table: "Investor_Payment_History",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<short>(
                name: "CredOrDebID",
                table: "Investor_Payment_History",
                type: "smallint",
                nullable: true,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<long>(
                name: "InvestorID",
                table: "Investor_Comp_Investment",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "InvestorID",
                table: "Investor_Comp_Intermediate",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "InvestorID",
                table: "Investor_Comp_History",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<short>(
                name: "CredOrDebID",
                table: "Investor_Comp_History",
                type: "smallint",
                nullable: true,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<long>(
                name: "PersonID",
                table: "Investor",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "NomineeID",
                table: "Investor",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "BankDetailsID",
                table: "Investor",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<short>(
                name: "AccountTypeID",
                table: "BankDetails",
                type: "smallint",
                nullable: true,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 30, 16, 14, 2, 241, DateTimeKind.Utc).AddTicks(6918));

            migrationBuilder.AddForeignKey(
                name: "FK_BankDetails_AccountType_AccountTypeID",
                table: "BankDetails",
                column: "AccountTypeID",
                principalTable: "AccountType",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Investor_BankDetails_BankDetailsID",
                table: "Investor",
                column: "BankDetailsID",
                principalTable: "BankDetails",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Investor_Nominee_NomineeID",
                table: "Investor",
                column: "NomineeID",
                principalTable: "Nominee",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Investor_Person_PersonID",
                table: "Investor",
                column: "PersonID",
                principalTable: "Person",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Investor_Comp_History_CredOrDeb_CredOrDebID",
                table: "Investor_Comp_History",
                column: "CredOrDebID",
                principalTable: "CredOrDeb",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Investor_Comp_History_Investor_InvestorID",
                table: "Investor_Comp_History",
                column: "InvestorID",
                principalTable: "Investor",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Investor_Comp_Intermediate_Investor_InvestorID",
                table: "Investor_Comp_Intermediate",
                column: "InvestorID",
                principalTable: "Investor",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Investor_Comp_Investment_Investor_InvestorID",
                table: "Investor_Comp_Investment",
                column: "InvestorID",
                principalTable: "Investor",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Investor_Payment_History_CredOrDeb_CredOrDebID",
                table: "Investor_Payment_History",
                column: "CredOrDebID",
                principalTable: "CredOrDeb",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Investor_Payment_History_Investor_InvestorID",
                table: "Investor_Payment_History",
                column: "InvestorID",
                principalTable: "Investor",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Investor_Payout_History_Investor_InvestorID",
                table: "Investor_Payout_History",
                column: "InvestorID",
                principalTable: "Investor",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Investor_Payout_Intermediate_Investor_InvestorID",
                table: "Investor_Payout_Intermediate",
                column: "InvestorID",
                principalTable: "Investor",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Investor_Payout_Investment_Investor_InvestorID",
                table: "Investor_Payout_Investment",
                column: "InvestorID",
                principalTable: "Investor",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Nominee_Relationship_RelationshipID",
                table: "Nominee",
                column: "RelationshipID",
                principalTable: "Relationship",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Gender_GenderID",
                table: "Person",
                column: "GenderID",
                principalTable: "Gender",
                principalColumn: "ID");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Person_MaritalStatuse_MaritalStatusID",
            //    table: "Person",
            //    column: "MaritalStatusID",
            //    principalTable: "MaritalStatuse",
            //    principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankDetails_AccountType_AccountTypeID",
                table: "BankDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Investor_BankDetails_BankDetailsID",
                table: "Investor");

            migrationBuilder.DropForeignKey(
                name: "FK_Investor_Nominee_NomineeID",
                table: "Investor");

            migrationBuilder.DropForeignKey(
                name: "FK_Investor_Person_PersonID",
                table: "Investor");

            migrationBuilder.DropForeignKey(
                name: "FK_Investor_Comp_History_CredOrDeb_CredOrDebID",
                table: "Investor_Comp_History");

            migrationBuilder.DropForeignKey(
                name: "FK_Investor_Comp_History_Investor_InvestorID",
                table: "Investor_Comp_History");

            migrationBuilder.DropForeignKey(
                name: "FK_Investor_Comp_Intermediate_Investor_InvestorID",
                table: "Investor_Comp_Intermediate");

            migrationBuilder.DropForeignKey(
                name: "FK_Investor_Comp_Investment_Investor_InvestorID",
                table: "Investor_Comp_Investment");

            migrationBuilder.DropForeignKey(
                name: "FK_Investor_Payment_History_CredOrDeb_CredOrDebID",
                table: "Investor_Payment_History");

            migrationBuilder.DropForeignKey(
                name: "FK_Investor_Payment_History_Investor_InvestorID",
                table: "Investor_Payment_History");

            migrationBuilder.DropForeignKey(
                name: "FK_Investor_Payout_History_Investor_InvestorID",
                table: "Investor_Payout_History");

            migrationBuilder.DropForeignKey(
                name: "FK_Investor_Payout_Intermediate_Investor_InvestorID",
                table: "Investor_Payout_Intermediate");

            migrationBuilder.DropForeignKey(
                name: "FK_Investor_Payout_Investment_Investor_InvestorID",
                table: "Investor_Payout_Investment");

            migrationBuilder.DropForeignKey(
                name: "FK_Nominee_Relationship_RelationshipID",
                table: "Nominee");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Person_Gender_GenderID",
            //    table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_MaritalStatuse_MaritalStatusID",
                table: "Person");

            migrationBuilder.AlterColumn<short>(
                name: "MaritalStatusID",
                table: "Person",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0,
                oldClrType: typeof(short),
                oldType: "smallint",
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "GenderID",
                table: "Person",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0,
                oldClrType: typeof(short),
                oldType: "smallint",
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "RelationshipID",
                table: "Nominee",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0,
                oldClrType: typeof(short),
                oldType: "smallint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "InvestorID",
                table: "Investor_Payout_Investment",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "InvestorID",
                table: "Investor_Payout_Intermediate",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "InvestorID",
                table: "Investor_Payout_History",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "InvestorID",
                table: "Investor_Payment_History",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "CredOrDebID",
                table: "Investor_Payment_History",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0,
                oldClrType: typeof(short),
                oldType: "smallint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "InvestorID",
                table: "Investor_Comp_Investment",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "InvestorID",
                table: "Investor_Comp_Intermediate",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "InvestorID",
                table: "Investor_Comp_History",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "CredOrDebID",
                table: "Investor_Comp_History",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0,
                oldClrType: typeof(short),
                oldType: "smallint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "PersonID",
                table: "Investor",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "NomineeID",
                table: "Investor",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "BankDetailsID",
                table: "Investor",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "AccountTypeID",
                table: "BankDetails",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0,
                oldClrType: typeof(short),
                oldType: "smallint",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 28, 16, 5, 57, 154, DateTimeKind.Utc).AddTicks(3248));

            migrationBuilder.AddForeignKey(
                name: "FK_BankDetails_AccountType_AccountTypeID",
                table: "BankDetails",
                column: "AccountTypeID",
                principalTable: "AccountType",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Investor_BankDetails_BankDetailsID",
                table: "Investor",
                column: "BankDetailsID",
                principalTable: "BankDetails",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Investor_Nominee_NomineeID",
                table: "Investor",
                column: "NomineeID",
                principalTable: "Nominee",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Investor_Person_PersonID",
                table: "Investor",
                column: "PersonID",
                principalTable: "Person",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Investor_Comp_History_CredOrDeb_CredOrDebID",
                table: "Investor_Comp_History",
                column: "CredOrDebID",
                principalTable: "CredOrDeb",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Investor_Comp_History_Investor_InvestorID",
                table: "Investor_Comp_History",
                column: "InvestorID",
                principalTable: "Investor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Investor_Comp_Intermediate_Investor_InvestorID",
                table: "Investor_Comp_Intermediate",
                column: "InvestorID",
                principalTable: "Investor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Investor_Comp_Investment_Investor_InvestorID",
                table: "Investor_Comp_Investment",
                column: "InvestorID",
                principalTable: "Investor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Investor_Payment_History_CredOrDeb_CredOrDebID",
                table: "Investor_Payment_History",
                column: "CredOrDebID",
                principalTable: "CredOrDeb",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Investor_Payment_History_Investor_InvestorID",
                table: "Investor_Payment_History",
                column: "InvestorID",
                principalTable: "Investor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Investor_Payout_History_Investor_InvestorID",
                table: "Investor_Payout_History",
                column: "InvestorID",
                principalTable: "Investor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Investor_Payout_Intermediate_Investor_InvestorID",
                table: "Investor_Payout_Intermediate",
                column: "InvestorID",
                principalTable: "Investor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Investor_Payout_Investment_Investor_InvestorID",
                table: "Investor_Payout_Investment",
                column: "InvestorID",
                principalTable: "Investor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Nominee_Relationship_RelationshipID",
                table: "Nominee",
                column: "RelationshipID",
                principalTable: "Relationship",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Gender_GenderID",
                table: "Person",
                column: "GenderID",
                principalTable: "Gender",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Person_MaritalStatuse_MaritalStatusID",
            //    table: "Person",
            //    column: "MaritalStatusID",
            //    principalTable: "MaritalStatuse",
            //    principalColumn: "ID",
            //    onDelete: ReferentialAction.Cascade);
        }
    }
}
