using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BetSports.Web.Data.Entities
{
    public class Zone
    {
        public int Id { get; set; }

        [Display(Name = "Zone")]
        [MaxLength(60, ErrorMessage = "The field {0} only can contain {1} characters length.")]
        [Required]
        public string Name { get; set; }

        public bool Status { get; set; }

        public ICollection<BankingSetting> BankingSettings { get; set; }
    }
}
