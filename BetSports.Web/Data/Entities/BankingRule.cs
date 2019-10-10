using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BetSports.Web.Data.Entities
{
    public class BankingRule
    {
        public int Id { get; set; }

        [Display(Name = "Direct")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal RegularDirect { get; set; }

        [Display(Name = "Pale")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal RegularPale { get; set; }

        [Display(Name = "Triplet")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal RegularTriplet { get; set; }

        [Display(Name = "Foursome")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal RegularFoursome { get; set; }

        [Display(Name = "Quintet")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal RegularQuintet { get; set; }

        [Display(Name = "Sextet")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal RegularSextet { get; set; }

        [Display(Name = "Septet")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal RegularSeptet { get; set; }

        [Display(Name = "Octet")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal RegularOctet { get; set; }

        [Display(Name = "9 Plays")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Regular9Plays { get; set; }

        [Display(Name = "10 Plays")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Regular10Plays { get; set; }

        [Display(Name = "11 Plays")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Regular11Plays { get; set; }

        [Display(Name = "12 Plays")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Regular12Plays { get; set; }

        [Display(Name = "13 Plays")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Regular13Plays { get; set; }
        
        [Display(Name = "14 Plays")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Regular14Plays { get; set; }

        [Display(Name = "15 Plays")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Regular15Plays { get; set; }

        [Display(Name = "16 Plays")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Regular16Plays { get; set; }



        [Display(Name = "Direct")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal IfDirect { get; set; }

        [Display(Name = "Pale")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal IfPale { get; set; }

        [Display(Name = "Triplet")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal IfTriplet { get; set; }

        [Display(Name = "Foursome")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal IfFoursome { get; set; }

        [Display(Name = "Quintet")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal IfQuintet { get; set; }

        [Display(Name = "Sextet")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal IfSextet { get; set; }

        [Display(Name = "Septet")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal IfSeptet { get; set; }

        [Display(Name = "Octet")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal IfOctet { get; set; }

        [Display(Name = "9 Plays")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal If9Plays { get; set; }

        [Display(Name = "10 Plays")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal If10Plays { get; set; }

        [Display(Name = "11 Plays")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal If11Plays { get; set; }

        [Display(Name = "12 Plays")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal If12Plays { get; set; }

        [Display(Name = "13 Plays")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal If13Plays { get; set; }

        [Display(Name = "14 Plays")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal If14Plays { get; set; }

        [Display(Name = "15 Plays")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal If15Plays { get; set; }

        [Display(Name = "16 Plays")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal If16Plays { get; set; }

        public ICollection<Banking> Bankings { get; set; }
    }
}
