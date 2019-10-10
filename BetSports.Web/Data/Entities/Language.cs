using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BetSports.Web.Data.Entities
{
    public class Language
    {
        public int Id { get; set; }

        [Display(Name = "Language")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Name { get; set; }

        public ICollection<Banking> Bankings { get; set; }

        public bool Status { get; set; }
    }
}
