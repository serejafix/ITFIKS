using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DZUniversity.Models;
using DZUniversity.ViewModels;

namespace DZUniversity.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly SchoolContext _context;

        public IndexModel(SchoolContext context)
        {
            _context = context;
        }
        public IList<CourseViewModel> CourseViewModels { get; set; }
        //public IList<Course> Courses { get;set; } = default!;

        public async Task OnGetAsync()
        {
            CourseViewModels = await _context.Courses.Select(x => new CourseViewModel
            {
                CourseID = x.CourseID,
                Title = x.Title,
                Credits = x.Credits,
                DepartmentName = x.Department.Name
            }).ToListAsync();
        }
    }
}
