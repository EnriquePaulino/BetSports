using BetSports.Web.Data.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace BetSports.Web.Models
{
    public class BankingViewModel
    {
        public Banking Banking { get; set; }

        public BankingSetting BankingSetting { get; set; }

        public Company Company { get; set; }

        public BankingException BankingException { get; set; }

        public BankingRule BankingRule { get; set; }

        public BankMaintenanceMode BankMaintenanceMode { get; set; }

        public Commission Commission { get; set; }

        public DrawerPoint DrawerPoint { get; set; }

        public League League { get; set; }

        public Language Language { get; set; }

        public Manager Manager { get; set; }

        public Schedule Schedule { get; set; }

        public TypePlay TypePlay { get; set; }

        public Zone Zone { get; set; }


        public IEnumerable<SelectListItem> ListBanking { get; set; }
    }
}
