using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetSports.Web.Data.Entities
{
    public class Manager
    {
        public int Id { get; set; }

        public User User { get; set; }
    }
}
