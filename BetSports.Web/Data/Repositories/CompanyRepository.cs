using BetSports.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetSports.Web.Data.Repositories
{
    public class CompanyRepository : GenericRepository<Company>, ICompanyRepository
    {
        private readonly DataContext _dataContext;

        public CompanyRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Company> GetCompany(int id)
        {
            return await _dataContext.Companies.FindAsync(id);
        }
    }
}
