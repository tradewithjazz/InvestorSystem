using InvestorSystem.DataModel.Table;
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

        public DbSet<User> Users { get; set; }

        public DbSet<Gender> Gender { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gender>().HasData(new Gender
            {
                GenderCD = "M",
                GenderName = "Male",
                Description = "Male"
            },
            new Gender
            {
                GenderCD = "F",
                GenderName = "Female",
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
        }
    }
}
