using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DZ_2.Data;
using DZ_2.Models.Cinema;

namespace DZ_2.Controllers.DZController
{
    public class FilmsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FilmsController(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index(string genre,string title,string director,string about,string time)
        {
            if (_context.Films == null)
            {
                return Problem("Films null");
            }   

            var applicationDbContext = _context.Films.Include(f => f.Session);

            if (!String.IsNullOrEmpty(title)) // поиск по title
            {
                applicationDbContext = applicationDbContext.Where(s => s.Title!.Contains(title)).Include(f => f.Session);
            }

            if (!String.IsNullOrEmpty(genre)) // поиск по title
            {
                applicationDbContext = applicationDbContext.Where(s => s.Genre!.Contains(genre)).Include(f => f.Session);
            }

            if (!String.IsNullOrEmpty(director))// поиск по режисеру
            {
                applicationDbContext = applicationDbContext.Where(s => s.Director!.Contains(director)).Include(f => f.Session);
            }

            if (!String.IsNullOrEmpty(about))// поиск по описанию
            {
                applicationDbContext = applicationDbContext.Where(s => s.AboutFilm!.Contains(about)).Include(f => f.Session);
            } 

            if (!String.IsNullOrEmpty(time))// поиск по времени
            {
                applicationDbContext = applicationDbContext.Where(f => f.Session.Morning!.Contains(time)).Include(f => f.Session);
            }
           
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Films/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var films = await _context.Films
                .Include(f => f.Session)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (films == null)
            {
                return NotFound();
            }

            return View(films);
        }
        // GET: Films/Create
        public IActionResult Create()
        {
            ViewData["SessionId"] = new SelectList(_context.Sessions, "Id", "Day");
            return View();
        }

        // POST: Films/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Director,Genre,AboutFilm,SessionId")] Films films)
        {
            if (ModelState.IsValid)
            {
                films.Id = Guid.NewGuid();
                _context.Add(films);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SessionId"] = new SelectList(_context.Sessions, "Id", "Day", films.SessionId);
            return View(films);
        }

        // GET: Films/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var films = await _context.Films.FindAsync(id);
            if (films == null)
            {
                return NotFound();
            }
            ViewData["SessionId"] = new SelectList(_context.Sessions, "Id", "Day", films.SessionId);
            return View(films);
        }

        // POST: Films/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Title,Director,Genre,AboutFilm,SessionId")] Films films)
        {
            if (id != films.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(films);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FilmsExists(films.Id))
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
            ViewData["SessionId"] = new SelectList(_context.Sessions, "Id", "Day", films.SessionId);
            return View(films);
        }

       
        // GET: Films/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var films = await _context.Films
                .Include(f => f.Session)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (films == null)
            {
                return NotFound();
            }

            return View(films);
        }

        // POST: Films/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var films = await _context.Films.FindAsync(id);
            _context.Films.Remove(films);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FilmsExists(Guid id)
        {
            return _context.Films.Any(e => e.Id == id);
        }
    }
}
