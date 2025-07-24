using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BFConfigApp.Data.Models;


namespace BFConfigApp.Data.AppData
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users => Set<User>();

        public DbSet<CaseConfiguration> CaseConfigurations => Set<CaseConfiguration>();

        public DbSet<CaseDetail> CaseDetails => Set<CaseDetail>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=app.db");
        }
    }
}
