using BetSports.Web.Data.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace BetSports.Web.Data.Repositories
{
    public interface IBankingRepository : IGenericRepository<Banking>
    {
        IEnumerable<SelectListItem> GetComboBancas();

        IEnumerable<SelectListItem> GetComboZonas();

        IEnumerable<SelectListItem> GetComboZonas(int zonaId);
    }
}
