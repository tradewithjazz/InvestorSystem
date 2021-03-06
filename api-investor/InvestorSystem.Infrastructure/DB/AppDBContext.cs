using InvestorSystem.DataModel.Table;
using InvestorSystem.DataModel.Table.MetaData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestorSystem.Infrastructure.DB
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        { }

        //Common Tables
        public DbSet<Person> Person { get; set; }
        public DbSet<Nominee> Nominee { get; set; }
        public DbSet<BankDetails> BankDetails { get; set; }


        //Investor Tables
        public DbSet<Investor> Investor { get; set; }

        public DbSet<Investor_Comp_History> Investor_Comp_History { get; set; }
        public DbSet<Investor_Comp_Intermediate> Investor_Comp_Intermediate { get; set; }
        public DbSet<Investor_Comp_Investment> Investor_Comp_Investment { get; set; }

        public DbSet<Investor_Payment_History> Investor_Payment_History { get; set; }
        public DbSet<Investor_Payout_History> Investor_Payout_History { get; set; }
        public DbSet<Investor_Payout_Intermediate> Investor_Payout_Intermediate { get; set; }
        public DbSet<Investor_Payout_Investment> Investor_Payout_Investment { get; set; }


        //Employee Tables
        public DbSet<Employee> Employee { get; set; }

        public DbSet<Employee_Comp_History> Employee_Comp_History { get; set; }
        public DbSet<Employee_Comp_Intermediate> Employee_Comp_Intermediate { get; set; }
        public DbSet<Employee_Comp_Investment> Employee_Comp_Investment { get; set; }

        public DbSet<Employee_Payment_History> Employee_Payment_History { get; set; }
        public DbSet<Employee_Payout_History> Employee_Payout_History { get; set; }
        public DbSet<Employee_Payout_Intermediate> Employee_Payout_Intermediate { get; set; }
        public DbSet<Employee_Payout_Investment> Employee_Payout_Investment { get; set; }


        //MetaDataTables
        public DbSet<AccountType> AccountType { get; set; }
        public DbSet<CredOrDeb> CredOrDeb { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<MaritalStatus> MaritalStatuse { get; set; }
        public DbSet<Relationship> Relationship { get; set; }
        public DbSet<TransactionType> TransactionType { get; set; }

        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gender>().HasData(new Gender { 
              ID = 1,
              Name = "Male",
              Description = "Male"
            },
            new Gender
            {
                ID = 2,
                Name = "Female",
                Description = "Female"
            });

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                CreatedDate = DateTime.UtcNow,
                DisplayName = "Invester System",
                IsDeleted = false,
                Password = "InvSys@123",
                UserEmail = "investor@system.com",
                UserName = "Invester System"
            });

            modelBuilder.Entity<MaritalStatus>().HasData(new MaritalStatus
            {
                ID = 1,
                Name = "Single"
            },
            new Gender
            {
                ID = 2,
                Name = "Married"
            },
            new Gender
            {
                ID = 3,
                Name = "Divorced"
            },
            new Gender
            {
                ID = 4,
                Name = "Widowed"
            });
        }
    }
}
