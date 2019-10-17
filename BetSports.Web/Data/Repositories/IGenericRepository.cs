using System.Linq;
using System.Threading.Tasks;

namespace BetSports.Web.Data.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll();

        Task<T> GetByIdAsync(int id);

        Task<T> GetMaxIdBankingAsync();

        Task CreateAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(T entity);

        Task<bool> ExistAsync(int id);
    }
}
