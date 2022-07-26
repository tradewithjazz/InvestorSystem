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
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options):base(options)
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


        //MetaDataTables
        public DbSet<AccountType> AccountType { get; set; }
        public DbSet<CredOrDeb> CredOrDeb { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<MaritalStatus> MaritalStatuse { get; set; }
        public DbSet<Relationship> Relationship { get; set; }
        public DbSet<TransactionType> TransactionType { get; set; }


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
        }
    }
}
