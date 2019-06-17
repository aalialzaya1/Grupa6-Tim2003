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
    public class NamjestajController : Controller
    {
        private readonly DatabaseContext _context;

        public NamjestajController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: Namjestajs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Namjestaj.ToListAsync());
        }

        // GET: Namjestajs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var namjestaj = await _context.Namjestaj
                .FirstOrDefaultAsync(m => m.NamjestajID == id);
            if (namjestaj == null)
            {
                return NotFound();
            }

            return View(namjestaj);
        }

        // GET: Namjestajs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Namjestajs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Kategorija,Cijena,Stil,Materijal,Dezen,Naziv")] Namjestaj namjestaj)
        {
            if (ModelState.IsValid)
            {
                _context.Add(namjestaj);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(namjestaj);
        }

        // GET: Namjestajs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var namjestaj = await _context.Namjestaj.FindAsync(id);
            if (namjestaj == null)
            {
                return NotFound();
            }
            return View(namjestaj);
        }

        // POST: Namjestajs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Kategorija,Cijena,Stil,Materijal,Dezen,Naziv")] Namjestaj namjestaj)
        {
            if (id != namjestaj.NamjestajID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(namjestaj);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NamjestajExists(namjestaj.NamjestajID))
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
            return View(namjestaj);
        }

        // GET: Namjestajs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var namjestaj = await _context.Namjestaj
                .FirstOrDefaultAsync(m => m.NamjestajID == id);
            if (namjestaj == null)
            {
                return NotFound();
            }

            return View(namjestaj);
        }

        // POST: Namjestajs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var namjestaj = await _context.Namjestaj.FindAsync(id);
            _context.Namjestaj.Remove(namjestaj);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NamjestajExists(int id)
        {
            return _context.Namjestaj.Any(e => e.NamjestajID == id);
        }
    }
}
