using BetSports.Web.Data;
using BetSports.Web.Data.Entities;
using BetSports.Web.Data.Repositories;
using BetSports.Web.Helpers;
using BetSports.Web.Models;
using IBSApp.Web.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BetSports.Web.Controllers
{
    [Authorize]
    public class BankingsController : Controller
    {
        private readonly DataContext _dataContext;
        private readonly IBankingRepository _bankingRepository;
        private readonly IUserHelper _userHelper;
        private readonly ICompanyRepository _companyRepository;
        private readonly IConverterHelper _converterHelper;

        public BankingsController(
            DataContext dataContext,
            IBankingRepository bankingRepository,
            IUserHelper userHelper,
            ICompanyRepository companyRepository,
            IConverterHelper converterHelper)
        {
            _dataContext = dataContext;
            _bankingRepository = bankingRepository;
            _userHelper = userHelper;
            _companyRepository = companyRepository;
            _converterHelper = converterHelper;
        }

        public IActionResult Index()
        {
            return View(_bankingRepository.GetAll());
        }

        public async Task<IActionResult> Create()
        {
            var banking = await _dataContext.Bankings.LastAsync();

            //var _model = _converterHelper.ToMaxIdBankingAsync(banking);

            var model = new BankingViewModel
            {
                Document = $"{banking.Document}"
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Banking banking)
        {
            if (ModelState.IsValid)
            {
                var company = await _companyRepository.GetCompany(1);

                //banking.User = await _userHelper.GetUserByEmailAsync(User.Identity.Name);
                //banking.IdType = company.IdType;
                //banking.FechaHora = DateTime.UtcNow;
                await _bankingRepository.CreateAsync(banking);
                return RedirectToAction(nameof(Index));
            }
            return View(banking);
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new NotFoundViewResult("BankingNotFound");
            }

            //var banking = await _dataContext.Bankings
            //   .Include(b => b.BankingSetting)
            //   .FirstOrDefaultAsync(b => b.Id == id);

            //if (banking == null)
            //{
            //    return null;
            //}
            //return null;

            var model = await _converterHelper.ToBankingDataAsync(id.Value);
            if (model == null)
            {
                return new NotFoundViewResult("BankingNotFound");
            }

            return View(model);
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(LottBanking Banking)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            var company = await _companyRepository.GetCompany(1);

        //            // TODO: Pending to change to: this.User.Identity.Name
        //            Banking.User = await _userHelper.GetUserByEmailAsync("paulinoenrique@gmail.com");
        //            Banking.IdType = company.IdType;
        //            Banking.FechaHora = DateTime.UtcNow;
        //            await _bankingRepository.UpdateAsync(Banking);
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!await _bankingRepository.ExistAsync(Banking.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }

        //    return View(Banking);
        //}

        //private BankingViewModel ToBancaViewModel(Banking banking)
        //{
        //    return new BankingViewModel
        //    {
        //        IdType = banking.IdType,
        //        Name = banking.Name,
        //        Address = banking.Address,
        //        PhoneNumber = banking.PhoneNumber,
        //        CxcCity = banking.CxcCity,
        //        DiaMaxPagoTcket = banking.DiaMaxPagoTcket,
        //        CxcZone = banking.CxcZone,
        //        ListZone = _bankingRepository.GetComboZonas(),
        //        PvdPrimera = banking.PvdPrimera,
        //        PvdSegunda = banking.PvdSegunda,
        //        PvdTercera = banking.PvdTercera,
        //        PvdDobles = banking.PvdDobles,
        //        PvpPrimera = banking.PvpPrimera,
        //        PvpSegunda = banking.PvpSegunda,
        //        PvpTercera = banking.PvpTercera,
        //        PvpSecuencia = banking.PvpSecuencia,
        //        PvtPrimera = banking.PvtPrimera,
        //        PvtSegunda = banking.PvtSegunda,
        //        PvCash3StraightSecuenia = banking.PvCash3StraightSecuenia,
        //        PvCash3StraightDobles = banking.PvCash3StraightDobles,
        //        PvCash3Box3Way2Identicos = banking.PvCash3Box3Way2Identicos,
        //        PvCash3Box6Way3Identicos = banking.PvCash3Box6Way3Identicos,
        //        PvPlay4StraightSecuencia = banking.PvPlay4StraightSecuencia,
        //        PvPlay4StraightDobles = banking.PvPlay4StraightDobles,
        //        PvPlay4Box4Way3Identicos = banking.PvPlay4Box4Way3Identicos,
        //        PvPlay4Box6Way6Identicos = banking.PvPlay4Box6Way6Identicos,
        //        PvPlay4Box12Way2Identicos = banking.PvPlay4Box12Way2Identicos,
        //        PvPick5StraightSecuencia = banking.PvPick5StraightSecuencia,
        //        PvPick5StraightDobles = banking.PvPick5StraightDobles,
        //        PvPick5Box5Way4Identicos = banking.PvPick5Box5Way4Identicos,
        //        PvPick5Box10Way3Identicos = banking.PvPick5Box10Way3Identicos,
        //        PvPick5Box20Way3Identicos = banking.PvPick5Box20Way3Identicos,
        //        PvPick5Box30Way2Identicos = banking.PvPick5Box30Way2Identicos,
        //        PvPick5Box60Way2Identicos = banking.PvPick5Box60Way2Identicos,
        //        PvPick5Box120Way5Unicos = banking.PvPick5Box120Way5Unicos,
        //        User = banking.User,
        //        Status = banking.Status
        //    };
        //}

        //public IActionResult BancaNotFound()
        //{
        //    return View();
        //}

        //public IActionResult CreateHour()
        //{
        //    var model = new HourViewModel
        //    {
        //        Timer = null,
        //        ListBanking = _bankingRepository.GetComboBancas()
        //    };
        //    return View(model);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> CreateHour(LottBanking banking)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var company = await _companyRepository.GetCompany(1);

        //        // TODO: Pending to change to: this.User.Identity.Name
        //        banking.User = await _userHelper.GetUserByEmailAsync("paulinoenrique@gmail.com");
        //        banking.IdType = company.IdType;
        //        banking.FechaHora = DateTime.UtcNow;
        //        await _bankingRepository.CreateAsync(banking);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(banking);
        //}

        //public IActionResult MakePlay()
        //{
        //    return View();
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> MakePlay(LottBanking banking)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var company = await _companyRepository.GetCompany(1);

        //        // TODO: Pending to change to: this.User.Identity.Name
        //        banking.User = await _userHelper.GetUserByEmailAsync("paulinoenrique@gmail.com");
        //        banking.IdType = company.IdType;
        //        banking.FechaHora = DateTime.UtcNow;
        //        await _bankingRepository.CreateAsync(banking);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(banking);
        //}

        //public IActionResult CreateZone()
        //{
        //    return View(_lotteryRepository.GetAll());
        //}
    }
}