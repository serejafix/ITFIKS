using DZUniversity.Models.SchoolViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace DZUniversity.Pages
{
    public class AboutModel : PageModel
    {
        private readonly SchoolContext _context;
        public void OnGet(SchoolContext context)
        {
            context = _context;
        }
        public IList<EnrollmentDateGroup> Students { get; set; }
        public async Task OnGetAsync()
        {
            IQueryable<EnrollmentDateGroup> data = _context.Students
                .GroupBy(s => s.EnrollmentDate)
                .Select(dateGroup => new EnrollmentDateGroup
                {
                    EnrollmentDate = dateGroup.Key,
                    StudentCount = dateGroup.Count()
                });

            Students = await data.AsNoTracking().ToListAsync();
        }
    }
}
