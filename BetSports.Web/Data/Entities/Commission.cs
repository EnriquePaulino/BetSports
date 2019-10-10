using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BetSports.Web.Data.Entities
{
    public class Commission
    {
        public int Id { get; set; }

        [Display(Name = "Bank Commission Amount")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal BankCommissionAmount { get; set; }

        [Display(Name = "Amount Personal Customer Commission")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal CustomerCommissionAmount { get; set; }

        [Display(Name = "Quad Frequency")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal QuadFrequency { get; set; }

        [Display(Name = "Commission Mode")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal CommissionMode { get; set; }

        [Display(Name = "Apply Commission Before Maintenance")]
        public bool ApplyCommissionBeforeMaintenance { get; set; }

        [Display(Name = "Add Percentage Maintenance in Red")]
        public bool AddPercentageMaintenanceRed { get; set; }

        [Display(Name = "Add fixed maintenance amount in red")]
        public bool AddFixedMaintenanceAmountRed { get; set; }


        public ICollection<Banking> Bankings { get; set; }

    }
}
