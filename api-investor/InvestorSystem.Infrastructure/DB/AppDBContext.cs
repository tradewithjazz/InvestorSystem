using InvestorSystem.DataModel.Table;
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

        public DbSet<WeatherForecast> WeatherForecast { get; set; }

        public DbSet<Gender> Genders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gender>().HasData(new Gender { 
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
        }
    }
}
