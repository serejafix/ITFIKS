﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DZUniversity.Models;

namespace DZUniversity.Pages.Students
{
    public class DeleteModel : PageModel
    {
        private readonly SchoolContext _context;
        private readonly ILogger<DeleteModel> _logger;
        public DeleteModel(SchoolContext context,ILogger<DeleteModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        [BindProperty]
        public Student Student { get; set; }
        public string ErrorMessage { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id, bool saveChangesError = false)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            Student = await _context.Students.AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);

            if (Student == null)
            {
                return NotFound();
            }
            if (saveChangesError)
            {
                ErrorMessage = String.Format("Delete {ID} failed. Try again", id);
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }
            var student = await _context.Students.FindAsync(id);
            if( student == null) { return NotFound(); }

            try
            {
                _context.Students.Remove(student);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError(ex, ErrorMessage);
                return RedirectToAction("./Delete", new { id, saveChangesError = true });
            } 
        }
    }
}