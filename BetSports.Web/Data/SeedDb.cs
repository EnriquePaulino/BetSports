using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetSports.Web.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckLanguageAsync();
        }

        private async Task CheckLanguageAsync()
        {
            if (!_context.Languages.Any())
            {
                _context.Languages.Add(new Entities.Language { Name = "English", Status = true });
                _context.Languages.Add(new Entities.Language { Name = "Spanish", Status = true });
                await _context.SaveChangesAsync();
            }
        }
    }
}
