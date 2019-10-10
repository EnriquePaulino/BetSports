using System.ComponentModel.DataAnnotations;

namespace BetSports.Web.Data.Entities
{
    public class BankingSetting
    {
        public int Id { get; set; }

        public Banking Banking { get; set; }

        [Display(Name = "Minutes to Cancel Ticket")]
        public int MinutesCancelTicket { get; set; }

        [Display(Name = "Maximum Tickets to Cancel per day")]
        public int MaximumTicketsCancelDay { get; set; }

        [Display(Name = "Minimum Ticket Amount")]
        public decimal MinimumTicketAmount { get; set; }

        [Display(Name = "Minimum Plays to buy Points")]
        public int MinimumPlaysBuyPoints { get; set; }

        [Display(Name = "Daily Sale Limit")]
        public int DailySaleLimit { get; set; }

        [Display(Name = "Deactivation Balance")]
        public int DeactivationBalance { get; set; }

        [Display(Name = "Minimum of Plays in the Future")]
        public int MinimumPlaysFuture { get; set; }

        [Display(Name = "Multi-Play Money Line")]
        public decimal MultiPlayMoneyLine { get; set; }

        [Display(Name = "Active")]
        public bool Active { get; set; }

        [Display(Name = "To Print")]
        public bool ToPrint { get; set; }

        [Display(Name = "Allow Reprint of Tickets")]
        public bool AllowReprintTickets { get; set; }

        [Display(Name = "Control of Winning Tickets")]
        public bool ControlWinningTickets { get; set; }

        [Display(Name = "Just Send SMS")]
        public bool JustSendSms { get; set; }

        [Display(Name = "Language")]
        public int Language { get; set; }

        [Display(Name = "Length of Numerical Code")]
        public int LengthNumericalCode { get; set; }

        [Display(Name = "Allow one Player Moves with his Parent Team")]
        public int AllowPlaysTeamParent { get; set; }

        [Display(Name = "Show Balance and Sales Transactions")]
        public int ShowBalanceSalesTransactions { get; set; }

        public Zone Zone { get; set; }
    }
}
