using BetSports.Web.Data.Entities;
using System.Threading.Tasks;

namespace BetSports.Web.Data.Repositories
{
    public interface ICompanyRepository : IGenericRepository<Company>
    {
        //IEnumerable<Company> GetCompany();

        Task<Company> GetCompany(int id);

        //Task<Company> GetDatos();
    }
}
