using System;
using System.ComponentModel.DataAnnotations;

namespace BetSports.Web.Data.Entities
{
    public class Banking : IEntity
    {
        [Required] 
        public int IdType { get; set; }

        public int Id { get; set; }

        [Display(Name = "Document")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Document { get; set; }

        [Display(Name = "Name")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Name { get; set; }

        [Display(Name = "Owner")]
        [MaxLength(50, ErrorMessage = "The field {0} only can contain {1} characters length.")]
        [Required]
        public string Owner { get; set; }

        [Display(Name = "Location")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Location { get; set; }

        [MaxLength(30)]
        public string FirstFooter { get; set; }

        [MaxLength(30)]
        public string SecondFooter { get; set; }

        [MaxLength(30)]
        public string ThirdFooter { get; set; }

        [MaxLength(30)]
        public string FourthFooter { get; set; }

        [MaxLength(30)]
        public string FifthFooter { get; set; }

        [Display(Name = "Full Document")]
        public string FullDocument => $"{IdType} - {Id} - {Document}";





        public Zone Zone { get; set; }

        public Commission Commission { get; set; }

        public BankingRule BankingRule { get; set; }

        public BankingException BankingException { get; set; }

        public Language Language { get; set; }

        public BankingSetting BankingSetting { get; set; }

        public BankMaintenanceMode BankMaintenanceMode { get; set; }

        public Schedule Schedule { get; set; }


        public User User { get; set; }

        public DateTime? FechaHora { get; set; }

    }
}
