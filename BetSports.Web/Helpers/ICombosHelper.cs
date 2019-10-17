using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BetSports.Web.Helpers
{
    public interface ICombosHelper
    {
        IEnumerable<SelectListItem> GetComboBancas();

        IEnumerable<SelectListItem> GetComboZonas();
    }
}