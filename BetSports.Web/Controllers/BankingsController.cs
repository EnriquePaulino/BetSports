using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BetSports.Web.Data;
using BetSports.Web.Data.Entities;

namespace BetSports.Web.Controllers
{
    public class BankingsController : Controller
    {
        private readonly DataContext _context;

        public BankingsController(DataContext context)
        {
            _context = context;
        }

        // GET: Bankings
        public async Task<IActionResult> Index()
        {
            return View(await _context.Bankings.ToListAsync());
        }

        // GET: Bankings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var banking = await _context.Bankings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (banking == null)
            {
                return NotFound();
            }

            return View(banking);
        }

        // GET: Bankings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bankings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Document,Name,Owner,Location,MinutesCancelTicket,MaximumTicketsCancelDay,MinimumTicketAmount,MinimumPlaysBuyPoints,DailySaleLimit,DeactivationBalance,MinimumPlaysFuture,MultiPlayMoneyLine,Active,ToPrint")] Banking banking)
        {
            if (ModelState.IsValid)
            {
                _context.Add(banking);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(banking);
        }

        // GET: Bankings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var banking = await _context.Bankings.FindAsync(id);
            if (banking == null)
            {
                return NotFound();
            }
            return View(banking);
        }

        // POST: Bankings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Document,Name,Owner,Location,MinutesCancelTicket,MaximumTicketsCancelDay,MinimumTicketAmount,MinimumPlaysBuyPoints,DailySaleLimit,DeactivationBalance,MinimumPlaysFuture,MultiPlayMoneyLine,Active,ToPrint")] Banking banking)
        {
            if (id != banking.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(banking);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BankingExists(banking.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(banking);
        }

        // GET: Bankings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var banking = await _context.Bankings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (banking == null)
            {
                return NotFound();
            }

            return View(banking);
        }

        // POST: Bankings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var banking = await _context.Bankings.FindAsync(id);
            _context.Bankings.Remove(banking);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BankingExists(int id)
        {
            return _context.Bankings.Any(e => e.Id == id);
        }
    }
}
