using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LetUsBringYourHomeStyle.Models;

namespace LetUsBringYourHomeStyle.Controllers
{
    public class PretragaController : Controller
    {
        private readonly DatabaseContext _context;

        public PretragaController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: Pretraga
        public async Task<IActionResult> Index()
        {
            return View(await _context.homeStyle.ToListAsync());
        }

        // GET: Pretraga/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeStyle = await _context.homeStyle
                .FirstOrDefaultAsync(m => m.homeStyleID == id);
            if (homeStyle == null)
            {
                return NotFound();
            }

            return View(homeStyle);
        }

        // GET: Pretraga/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pretraga/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("homeStyleID,SubjektStanje")] homeStyle homeStyle)
        {
            if (ModelState.IsValid)
            {
                _context.Add(homeStyle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(homeStyle);
        }

        // GET: Pretraga/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeStyle = await _context.homeStyle.FindAsync(id);
            if (homeStyle == null)
            {
                return NotFound();
            }
            return View(homeStyle);
        }

        // POST: Pretraga/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("homeStyleID,SubjektStanje")] homeStyle homeStyle)
        {
            if (id != homeStyle.homeStyleID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(homeStyle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!homeStyleExists(homeStyle.homeStyleID))
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
            return View(homeStyle);
        }

        // GET: Pretraga/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeStyle = await _context.homeStyle
                .FirstOrDefaultAsync(m => m.homeStyleID == id);
            if (homeStyle == null)
            {
                return NotFound();
            }

            return View(homeStyle);
        }

        // POST: Pretraga/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var homeStyle = await _context.homeStyle.FindAsync(id);
            _context.homeStyle.Remove(homeStyle);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool homeStyleExists(int id)
        {
            return _context.homeStyle.Any(e => e.homeStyleID == id);
        }
    }
}
