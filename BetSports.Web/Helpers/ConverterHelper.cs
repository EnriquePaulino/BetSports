using BetSports.Web.Data;
using BetSports.Web.Data.Entities;
using BetSports.Web.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BetSports.Web.Helpers
{
    public class ConverterHelper : IConverterHelper
    {
        private readonly DataContext _dataContext;
        private readonly ICombosHelper _combosHelper;

        public ConverterHelper(
            DataContext dataContext,
            ICombosHelper combosHelper)
        {
            _dataContext = dataContext;
            _combosHelper = combosHelper;
        }

        public Banking ToMaxIdBankingAsync(Banking banking)
        {
            //var setting = await _dataContext.BankingSettings
            //    .Include(b => b.Bankings)
            //    .Where(b => b.Id == banking.Id);
            //var setting = _dataContext.Bankings
            //    .Include(bank => bank.BankingSettingId);

            //var _setting = this.ToBankingSetting(setting);
            //if (_setting == null)
            //{
            return null;
            //}

            //return new BankingViewModel
            //{
            //    IdType = banking.IdType,
            //    Id = banking.Id,
            //    Document = banking.Document
            //    //BankingSettingId = setting.BankingSettingId,
            //    //MinutesCancelTicket = setting.MinutesCancelTicket,
            //    //MaximumTicketsCancelDay = setting.MaximumTicketsCancelDay,
            //    //MinimumTicketAmount = setting.MinimumTicketAmount
            //};
        }

        private BankingViewModel ToBankingSetting(BankingViewModel setting)
        {
            return new BankingViewModel
            {
                //MinutesCancelTicket = setting.MinutesCancelTicket,
                //MaximumTicketsCancelDay = setting.MaximumTicketsCancelDay,
                //MinimumTicketAmount = setting.MinimumTicketAmount
                //MinimumPlaysBuyPoints = setting.MinimumPlaysBuyPoints,
                //DailySaleLimit = setting.DailySaleLimit,
                //DeactivationBalance = setting.DeactivationBalance,
                //MinimumPlaysFuture = setting.MinimumPlaysFuture,
                //MultiPlayMoneyLine = setting.MultiPlayMoneyLine,
                //Active = setting.Active,
                //ToPrint = setting.ToPrint.
                //AllowReprintTickets = setting.AllowReprintTickets,
                //ControlWinningTickets = setting.ControlWinningTickets,
                //JustSendSms = setting.JustSendSms,
                //Language = setting.Language,
                //LengthNumericalCode = setting.LengthNumericalCode,
                //AllowPlaysTeamParent = setting.AllowPlaysTeamParent,
                //ShowBalanceSalesTransactions = setting.ShowBalanceSalesTransactions
            };
        }


        public async Task<BankingViewModel> ToBankingDataAsync(int? id)
        {
            var banking = await _dataContext.Bankings
              .Include(b => b.BankingSetting)
              .FirstOrDefaultAsync(b => b.Id == id);

            if (banking == null)
            {
                return null;
            }

            return new BankingViewModel
            {
                Document = banking.Document,
                Name = banking.Name,
                Owner = banking.Owner,
                Location = banking.Location
            };

            //return null;
        }
    }
}
