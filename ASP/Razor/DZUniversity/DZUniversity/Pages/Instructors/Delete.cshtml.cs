﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DZUniversity.Models;

namespace DZUniversity.Pages.Instructors
{
    public class DeleteModel : PageModel
    {
        private readonly SchoolContext _context;

        public DeleteModel(SchoolContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Instructor Instructor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Instructors == null)
            {
                return NotFound();
            }

            Instructor = await _context.Instructors.FirstOrDefaultAsync(m => m.Id == id);

            if (Instructor == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Instructors == null)
            {
                return NotFound();
            }
            Instructor instructor = await _context.Instructors
                                                   .Include(i => i.Courses)
                                                   .SingleAsync(i => i.Id == id);

            if (instructor == null)
            {
                return RedirectToPage("./Index");
            }


            var departments = await _context.Departments
                .Where(d => d.InstructorId == id)
                .ToListAsync();
            departments.ForEach(d => d.InstructorId = null);
            _context.Instructors.Remove(instructor);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }
}
