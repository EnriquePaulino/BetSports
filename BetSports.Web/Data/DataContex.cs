using System.Collections.Generic;
using BetSports.Web.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BetSports.Web.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Company> Companies { get; set; }

        public DbSet<Banking> Bankings { get; set; }

        public DbSet<BankingException> BankingExceptions { get; set; }

        public DbSet<BankingRule> BankingRules { get; set; }

        public DbSet<BankingSetting> BankingSettings { get; set; }

        public DbSet<BankMaintenanceMode> BankMaintenanceModes { get; set; }

        public DbSet<Commission> Commissions { get; set; }

        public DbSet<DrawerPoint> DrawerPoints { get; set; }

        public DbSet<League> Leagues { get; set; }

        public DbSet<Language> Languages { get; set; }

        public DbSet<Manager> Managers { get; set; }

        public DbSet<Schedule> Schedules { get; set; }

        public DbSet<TypePlay> TypePlays { get; set; }

        public DbSet<Zone> Zones { get; set; }
        public IEnumerable<object> Banking { get; internal set; }
    }
}
