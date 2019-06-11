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
    public class RegistrovaniKorisniksPrijavaController : Controller
    {
        private readonly DatabaseContext _context;

        public RegistrovaniKorisniksPrijavaController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: RegistrovaniKorisniksPrijava
        public async Task<IActionResult> Index()
        {
            return View(await _context.RegistrovaniKorisnik.ToListAsync());
        }

        // GET: RegistrovaniKorisniksPrijava/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registrovaniKorisnik = await _context.RegistrovaniKorisnik
                .FirstOrDefaultAsync(m => m.RegistrovaniKorisnikID == id);
            if (registrovaniKorisnik == null)
            {
                return NotFound();
            }

            return View(registrovaniKorisnik);
        }

        // GET: RegistrovaniKorisniksPrijava/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RegistrovaniKorisniksPrijava/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PopustID,Ime,Prezime,DatumRodjenja,Adresa,Grad,Telefon,Email,Username,Password")] RegistrovaniKorisnik registrovaniKorisnik)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registrovaniKorisnik);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(registrovaniKorisnik);
        }

        // GET: RegistrovaniKorisniksPrijava/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registrovaniKorisnik = await _context.RegistrovaniKorisnik.FindAsync(id);
            if (registrovaniKorisnik == null)
            {
                return NotFound();
            }
            return View(registrovaniKorisnik);
        }

        // POST: RegistrovaniKorisniksPrijava/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PopustID,Ime,Prezime,DatumRodjenja,Adresa,Grad,Telefon,Email,Username,Password")] RegistrovaniKorisnik registrovaniKorisnik)
        {
            if (id != registrovaniKorisnik.RegistrovaniKorisnikID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(registrovaniKorisnik);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegistrovaniKorisnikExists(registrovaniKorisnik.RegistrovaniKorisnikID))
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
            return View(registrovaniKorisnik);
        }

        // GET: RegistrovaniKorisniksPrijava/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registrovaniKorisnik = await _context.RegistrovaniKorisnik
                .FirstOrDefaultAsync(m => m.RegistrovaniKorisnikID == id);
            if (registrovaniKorisnik == null)
            {
                return NotFound();
            }

            return View(registrovaniKorisnik);
        }

        // POST: RegistrovaniKorisniksPrijava/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var registrovaniKorisnik = await _context.RegistrovaniKorisnik.FindAsync(id);
            _context.RegistrovaniKorisnik.Remove(registrovaniKorisnik);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegistrovaniKorisnikExists(int id)
        {
            return _context.RegistrovaniKorisnik.Any(e => e.RegistrovaniKorisnikID == id);
        }
    }
}
