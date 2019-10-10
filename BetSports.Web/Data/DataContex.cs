using BetSports.Web.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BetSports.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Banking> Bankings { get; set; }

        public DbSet<Language> Languages { get; set; }
    }
}
