using BetSports.Web.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BetSports.Web.Helpers
{
    public class CombosHelper : ICombosHelper
    {
        private readonly DataContext _dataContext;

        public CombosHelper(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IEnumerable<SelectListItem> GetComboBancas()
        {
            var list = _dataContext.Bankings.Select(c => new SelectListItem
            {
                Text = c.Name,
                Value = c.Id.ToString()
            }).OrderBy(l => l.Text).ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "(Seleciona una Banca...)",
                Value = "0"
            });

            return list;
        }

        public IEnumerable<SelectListItem> GetComboZonas()
        {
            var list = _dataContext.Zones.Select(c => new SelectListItem
            {
                Text = c.Name,
                Value = c.Id.ToString()
            }).OrderBy(l => l.Text).ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "(Seleciona una Zona...)",
                Value = "0"
            });

            return list;
        }

        public IEnumerable<SelectListItem> GetComboZonas(int zonaId)
        {
            throw new System.NotImplementedException();
        }
    }
}
