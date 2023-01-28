﻿using System;
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
    public class SessionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SessionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Sessions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Sessions.ToListAsync());
        }

        // GET: Sessions/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sessions = await _context.Sessions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sessions == null)
            {
                return NotFound();
            }

            return View(sessions);
        }

        // GET: Sessions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sessions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Morning,Day,Night")] Sessions sessions)
        {
            if (ModelState.IsValid)
            {
                sessions.Id = Guid.NewGuid();
                _context.Add(sessions);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sessions);
        }

        // GET: Sessions/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sessions = await _context.Sessions.FindAsync(id);
            if (sessions == null)
            {
                return NotFound();
            }
            return View(sessions);
        }

        // POST: Sessions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Morning,Day,Night")] Sessions sessions)
        {
            if (id != sessions.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sessions);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SessionsExists(sessions.Id))
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
            return View(sessions);
        }

        // GET: Sessions/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sessions = await _context.Sessions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sessions == null)
            {
                return NotFound();
            }

            return View(sessions);
        }

        // POST: Sessions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var sessions = await _context.Sessions.FindAsync(id);
            _context.Sessions.Remove(sessions);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SessionsExists(Guid id)
        {
            return _context.Sessions.Any(e => e.Id == id);
        }
    }
}
