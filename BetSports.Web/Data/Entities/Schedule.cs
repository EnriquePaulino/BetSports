using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetSports.Web.Data.Entities
{
    public class Schedule
    {
        public int Id { get; set; }

        public DateTime? MondayFrom { get; set; }

        public DateTime? TuesdayFrom { get; set; }

        public DateTime? WednesdayFrom { get; set; }

        public DateTime? ThursdayFrom { get; set; }

        public DateTime? FridayFrom { get; set; }

        public DateTime? SaturdayFrom { get; set; }

        public DateTime? SundayFrom { get; set; }


        public DateTime? MondayUntil { get; set; }

        public DateTime? TuesdayUntil { get; set; }

        public DateTime? WednesdayUntil { get; set; }

        public DateTime? ThursdayUntil { get; set; }

        public DateTime? FridayUntil { get; set; }

        public DateTime? SaturdayUntil { get; set; }

        public DateTime? SundayUntil { get; set; }

        public ICollection<Banking> Bankings { get; set; }
    }
}
