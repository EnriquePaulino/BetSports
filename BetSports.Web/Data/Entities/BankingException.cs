using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BetSports.Web.Data.Entities
{
    public class BankingException
    {
        public int Id { get; set; }

        public int FirstPlays { get; set; }

        public int SecondPlays { get; set; }

        [Display(Name = "Date")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime ExceptionDate { get; set; }

        public bool TypeException { get; set; }

        public ICollection<Banking> Bankings { get; set; }
    }
}
