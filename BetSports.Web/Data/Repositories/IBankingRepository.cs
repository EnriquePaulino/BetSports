using BetSports.Web.Data.Entities;
using BetSports.Web.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BetSports.Web.Data.Repositories
{
    public interface IBankingRepository : IGenericRepository<Banking>
    {
        //IEnumerable<SelectListItem> GetComboBancas();

        //IEnumerable<SelectListItem> GetComboZonas();

        //IEnumerable<SelectListItem> GetComboZonas(int zonaId);
    }
}
