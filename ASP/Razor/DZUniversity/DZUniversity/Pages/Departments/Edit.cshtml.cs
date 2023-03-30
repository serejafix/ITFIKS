﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DZUniversity.Models;

namespace DZUniversity.Pages.Departments
{
    public class EditModel : PageModel
    {
        private readonly SchoolContext _context;

        public EditModel(SchoolContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Department Department { get; set; } = default!;
        public SelectList InstructorNameSL { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {

            Department = await _context.Departments.Include(d => d.Administrator)
                .AsNoTracking().FirstOrDefaultAsync(m => m.DepartmentID == id);
                   
            if (Department == null)
            {
                return NotFound();
            }
            InstructorNameSL = new SelectList(_context.Instructors, "Id", "FirstMidName");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var departmentToUpdate = await _context.Departments.Include(m => m.Administrator)
                .FirstOrDefaultAsync(a => a.DepartmentID == id);

            if (departmentToUpdate == null)
            {
                return HandleDeletedDepartment();
            }
             
            _context.Entry(departmentToUpdate)
                .Property(d => d.ConcurrencyTokey)
                .OriginalValue = departmentToUpdate.ConcurrencyTokey;
            if (await TryUpdateModelAsync<Department>(
                departmentToUpdate,
                "Department",
                s => s.Name, s => s.StartDate, s => s.Budget, s => s.InstructorId))
            {
                try
                {
                    await _context.SaveChangesAsync();
                    RedirectToPage("./Index");
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    var exceptionEntry = ex.Entries.Single();
                    var clientValues = (Department)exceptionEntry.Entity;
                    var databaseEntry = exceptionEntry.GetDatabaseValues();
                    if (databaseEntry == null)
                    {
                        ModelState.AddModelError(string.Empty, "Unable to save." +
                           "The department was deleted by another user.");
                        return Page();
                    }
                    var dbValues = (Department)databaseEntry.ToObject();
                    await SetDbErrorMessage(dbValues, clientValues, _context);

                    Department.ConcurrencyTokey = (byte[])dbValues.ConcurrencyTokey;
                    ModelState.Remove($"{nameof(Department)}.{nameof(Department.ConcurrencyTokey)}");

                }
            }
            InstructorNameSL = new SelectList(
                    _context.Instructors,
                    "Id",
                    "FullName",
                    departmentToUpdate.InstructorId);
            return Page();
        }
        private IActionResult HandleDeletedDepartment()
        {
            var deletedDepartment = new Department();
            ModelState.AddModelError(string.Empty, "Unable to save.The department was deleted by another user.");
            InstructorNameSL = new SelectList(_context.Instructors,
                "Id",
                "FullName",
                Department.InstructorId);
            return Page();
        }
        private async Task SetDbErrorMessage(
            Department dbValues,
            Department clientValues,
            SchoolContext context)
        {

            if (dbValues.Name != clientValues.Name)
            {
                ModelState.AddModelError("Department.Name",
                    $"Current value: {dbValues.Name}");
            }
            if (dbValues.Budget != clientValues.Budget)
            {
                ModelState.AddModelError("Department.Budget",
                    $"Current value: {dbValues.Budget:c}");
            }
            if (dbValues.StartDate != clientValues.StartDate)
            {
                ModelState.AddModelError("Department.StartDate",
                    $"Current value: {dbValues.StartDate:d}");
            }
            if (dbValues.InstructorId != clientValues.InstructorId)
            {
                Instructor dbInstructor = await _context.Instructors
                   .FindAsync(dbValues.InstructorId);
                ModelState.AddModelError("Department.InstructorID",
                    $"Current value: {dbInstructor?.FullName}");
            }

            ModelState.AddModelError(string.Empty,
                "The record you attempted to edit "
              + "was modified by another user after you. The "
              + "edit operation was canceled and the current values in the database "
              + "have been displayed. If you still want to edit this record, click "
              + "the Save button again.");
        }
    }
}
