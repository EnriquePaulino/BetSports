using BetSports.Web.Data.Entities;
using BetSports.Web.Models;
using System.Threading.Tasks;

namespace BetSports.Web.Helpers
{
    public interface IConverterHelper
    {
        Banking ToMaxIdBankingAsync(Banking banking);

        Task<BankingViewModel> ToBankingDataAsync(int? id);
    }
}