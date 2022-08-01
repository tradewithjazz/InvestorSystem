﻿// <auto-generated />
using System;
using InvestorSystem.Infrastructure.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace InvestorSystem.Infrastructure.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20220728091201_GenderChanges_6")]
    partial class GenderChanges_6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("InvestorSystem.DataModel.Table.BankDetails", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<string>("AccountName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<short>("AccountTypeID")
                        .HasColumnType("smallint");

                    b.Property<int?>("AccounttypeID")
                        .HasColumnType("integer");

                    b.Property<string>("BankName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("IFSC")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("AccounttypeID");

                    b.ToTable("BankDetails");
                });

            modelBuilder.Entity("InvestorSystem.DataModel.Table.Gender", b =>
                {
                    b.Property<short>("ID")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(1)
                        .HasColumnType("smallint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<short>("ID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Gender");

                    b.HasData(
                        new
                        {
                            ID = (short)1,
                            Description = "Male",
                            Name = "Male"
                        },
                        new
                        {
                            ID = (short)2,
                            Description = "Female",
                            Name = "Female"
                        });
                });

            modelBuilder.Entity("InvestorSystem.DataModel.Table.Investor", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<long>("BankDetailsID")
                        .HasColumnType("bigint");

                    b.Property<long>("NomineeID")
                        .HasColumnType("bigint");

                    b.Property<long>("PersonID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("BankDetailsID");

                    b.HasIndex("NomineeID");

                    b.HasIndex("PersonID");

                    b.ToTable("Investor");
                });

            modelBuilder.Entity("InvestorSystem.DataModel.Table.Investor_Comp_History", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<long>("Amount")
                        .HasColumnType("bigint");

                    b.Property<short>("CredOrDebID")
                        .HasColumnType("smallint");

                    b.Property<long>("InvestorID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("CredOrDebID");

                    b.HasIndex("InvestorID");

                    b.ToTable("Investor_Comp_History");
                });

            modelBuilder.Entity("InvestorSystem.DataModel.Table.Investor_Comp_Intermediate", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<long>("Amount")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("AsOfDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("InvestorID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("InvestorID")
                        .IsUnique();

                    b.ToTable("Investor_Comp_Intermediate");
                });

            modelBuilder.Entity("InvestorSystem.DataModel.Table.Investor_Comp_Investment", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<long>("Amount")
                        .HasColumnType("bigint");

                    b.Property<long>("InvestorID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("ID");

                    b.HasIndex("InvestorID")
                        .IsUnique();

                    b.ToTable("Investor_Comp_Investment");
                });

            modelBuilder.Entity("InvestorSystem.DataModel.Table.Investor_Payment_History", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<long>("Amount")
                        .HasColumnType("bigint");

                    b.Property<short>("CredOrDebID")
                        .HasColumnType("smallint");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<long>("InvestorID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("CredOrDebID");

                    b.HasIndex("InvestorID")
                        .IsUnique();

                    b.ToTable("Investor_Payment_History");
                });

            modelBuilder.Entity("InvestorSystem.DataModel.Table.Investor_Payout_History", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<long>("Amount")
                        .HasColumnType("bigint");

                    b.Property<long>("InvestorID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("PaidOn")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("ID");

                    b.HasIndex("InvestorID")
                        .IsUnique();

                    b.ToTable("Investor_Payout_History");
                });

            modelBuilder.Entity("InvestorSystem.DataModel.Table.Investor_Payout_Intermediate", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<long>("Amount")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("ForDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("InvestorID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("InvestorID")
                        .IsUnique();

                    b.ToTable("Investor_Payout_Intermediate");
                });

            modelBuilder.Entity("InvestorSystem.DataModel.Table.Investor_Payout_Investment", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<long>("Amount")
                        .HasColumnType("bigint");

                    b.Property<long>("InvestorID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("ID");

                    b.HasIndex("InvestorID")
                        .IsUnique();

                    b.ToTable("Investor_Payout_Investment");
                });

            modelBuilder.Entity("InvestorSystem.DataModel.Table.MaritalStatus", b =>
                {
                    b.Property<short>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<short>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("MaritalStatuse");
                });

            modelBuilder.Entity("InvestorSystem.DataModel.Table.MetaData.AccountType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("AccountType");
                });

            modelBuilder.Entity("InvestorSystem.DataModel.Table.MetaData.CredOrDeb", b =>
                {
                    b.Property<short>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<short>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("CredOrDeb");
                });

            modelBuilder.Entity("InvestorSystem.DataModel.Table.MetaData.Nominee", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<short>("RelationshipID")
                        .HasColumnType("smallint");

                    b.HasKey("ID");

                    b.HasIndex("RelationshipID");

                    b.ToTable("Nominee");
                });

            modelBuilder.Entity("InvestorSystem.DataModel.Table.Person", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("AddressLine2")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("AlternateMobileNo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<short>("GenderID")
                        .HasColumnType("smallint");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<short>("MaritalStatusID")
                        .HasColumnType("smallint");

                    b.Property<string>("MobileNo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("GenderID");

                    b.HasIndex("MaritalStatusID");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("InvestorSystem.DataModel.Table.Relationship", b =>
                {
                    b.Property<short>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<short>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Relationship");
                });

            modelBuilder.Entity("InvestorSystem.DataModel.Table.TransactionType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("TransactionType");
                });

            modelBuilder.Entity("InvestorSystem.DataModel.Table.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 7, 28, 9, 12, 0, 878, DateTimeKind.Utc).AddTicks(5154),
                            DisplayName = "Invester System",
                            IsDeleted = false,
                            Password = "InvSys@123",
                            UserEmail = "investor@system.com",
                            UserName = "Invester System"
                        });
                });

            modelBuilder.Entity("InvestorSystem.DataModel.Table.BankDetails", b =>
                {
                    b.HasOne("InvestorSystem.DataModel.Table.MetaData.AccountType", "Accounttype")
                        .WithMany()
                        .HasForeignKey("AccounttypeID");

                    b.Navigation("Accounttype");
                });

            modelBuilder.Entity("InvestorSystem.DataModel.Table.Investor", b =>
                {
                    b.HasOne("InvestorSystem.DataModel.Table.BankDetails", "BankDetails")
                        .WithMany()
                        .HasForeignKey("BankDetailsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InvestorSystem.DataModel.Table.MetaData.Nominee", "Nominee")
                        .WithMany()
                        .HasForeignKey("NomineeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InvestorSystem.DataModel.Table.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BankDetails");

                    b.Navigation("Nominee");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("InvestorSystem.DataModel.Table.Investor_Comp_History", b =>
                {
                    b.HasOne("InvestorSystem.DataModel.Table.MetaData.CredOrDeb", "CredOrDeb")
                        .WithMany()
                        .HasForeignKey("CredOrDebID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InvestorSystem.DataModel.Table.Investor", "Investor")
                        .WithMany("Investor_Comp_History")
                        .HasForeignKey("InvestorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CredOrDeb");

                    b.Navigation("Investor");
                });

            modelBuilder.Entity("InvestorSystem.DataModel.Table.Investor_Comp_Intermediate", b =>
                {
                    b.HasOne("InvestorSystem.DataModel.Table.Investor", "Investor")
                        .WithOne("Investor_Comp_Intermediate")
                        .HasForeignKey("InvestorSystem.DataModel.Table.Investor_Comp_Intermediate", "InvestorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Investor");
                });

            modelBuilder.Entity("InvestorSystem.DataModel.Table.Investor_Comp_Investment", b =>
                {
                    b.HasOne("InvestorSystem.DataModel.Table.Investor", "Investor")
                        .WithOne("Investor_Comp_Investment")
                        .HasForeignKey("InvestorSystem.DataModel.Table.Investor_Comp_Investment", "InvestorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Investor");
                });

            modelBuilder.Entity("InvestorSystem.DataModel.Table.Investor_Payment_History", b =>
                {
                    b.HasOne("InvestorSystem.DataModel.Table.MetaData.CredOrDeb", "CredOrDeb")
                        .WithMany()
                        .HasForeignKey("CredOrDebID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InvestorSystem.DataModel.Table.Investor", "Investor")
                        .WithOne("Investor_Payment_History")
                        .HasForeignKey("InvestorSystem.DataModel.Table.Investor_Payment_History", "InvestorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CredOrDeb");

                    b.Navigation("Investor");
                });

            modelBuilder.Entity("InvestorSystem.DataModel.Table.Investor_Payout_History", b =>
                {
                    b.HasOne("InvestorSystem.DataModel.Table.Investor", "Investor")
                        .WithOne("Investor_Payout_History")
                        .HasForeignKey("InvestorSystem.DataModel.Table.Investor_Payout_History", "InvestorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Investor");
                });

            modelBuilder.Entity("InvestorSystem.DataModel.Table.Investor_Payout_Intermediate", b =>
                {
                    b.HasOne("InvestorSystem.DataModel.Table.Investor", "Investor")
                        .WithOne("Investor_Payout_Intermediate")
                        .HasForeignKey("InvestorSystem.DataModel.Table.Investor_Payout_Intermediate", "InvestorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Investor");
                });

            modelBuilder.Entity("InvestorSystem.DataModel.Table.Investor_Payout_Investment", b =>
                {
                    b.HasOne("InvestorSystem.DataModel.Table.Investor", "Investor")
                        .WithOne("Investor_Payout_Investment")
                        .HasForeignKey("InvestorSystem.DataModel.Table.Investor_Payout_Investment", "InvestorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Investor");
                });

            modelBuilder.Entity("InvestorSystem.DataModel.Table.MetaData.Nominee", b =>
                {
                    b.HasOne("InvestorSystem.DataModel.Table.Relationship", "Relationship")
                        .WithMany()
                        .HasForeignKey("RelationshipID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Relationship");
                });

            modelBuilder.Entity("InvestorSystem.DataModel.Table.Person", b =>
                {
                    b.HasOne("InvestorSystem.DataModel.Table.Gender", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InvestorSystem.DataModel.Table.MaritalStatus", "MaritalStatus")
                        .WithMany()
                        .HasForeignKey("MaritalStatusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gender");

                    b.Navigation("MaritalStatus");
                });

            modelBuilder.Entity("InvestorSystem.DataModel.Table.Investor", b =>
                {
                    b.Navigation("Investor_Comp_History");

                    b.Navigation("Investor_Comp_Intermediate");

                    b.Navigation("Investor_Comp_Investment");

                    b.Navigation("Investor_Payment_History");

                    b.Navigation("Investor_Payout_History");

                    b.Navigation("Investor_Payout_Intermediate");

                    b.Navigation("Investor_Payout_Investment");
                });
#pragma warning restore 612, 618
        }
    }
}
