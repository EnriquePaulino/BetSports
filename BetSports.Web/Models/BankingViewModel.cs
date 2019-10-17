using BetSports.Web.Data.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BetSports.Web.Models
{
    public class BankingViewModel : Banking
    {
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

        //[Display(Name = "First Footer")]
        //[MaxLength(30)]
        //public string FirstFooter { get; set; }

        //[Display(Name = "Second Footer")]
        //[MaxLength(30)]
        //public string SecondFooter { get; set; }

        //[Display(Name = "Third Footer")]
        //[MaxLength(30)]
        //public string ThirdFooter { get; set; }

        //[Display(Name = "Fourth Footer")]
        //[MaxLength(30)]
        //public string FourthFooter { get; set; }

        //[Display(Name = "Fifth Footer")]
        //[MaxLength(30)]
        //public string FifthFooter { get; set; }

        //[Display(Name = "Full Document")]
        //public string FullDocument => $"{IdType}-{Id}-{Document}";


        //// BankingSetting
        //public int BankingSettingId { get; set; }

        //[Display(Name = "Minutes to Cancel Ticket")]
        //public int MinutesCancelTicket { get; set; }

        //[Display(Name = "Maximum Tickets to Cancel per day")]
        //public int MaximumTicketsCancelDay { get; set; }

        //[Display(Name = "Minimum Ticket Amount")]
        //public decimal MinimumTicketAmount { get; set; }

        ////public IEnumerable<SelectListItem> ListBanking { get; set; }
    }
}
