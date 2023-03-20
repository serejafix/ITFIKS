using DZ.Models.RazorPagesApp.Models;
using DZ.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace DZ.Pages
{
    public class EditModel : PageModel
    {
        ApplicationContext _context;

        [BindProperty]
        public News? News { get; private set; }
        public EditModel(ApplicationContext db)
        {
            _context = db;
        }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.News == null)
            {
                return NotFound();
            }

            News = await _context.News.FindAsync(id);

            if (News == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.News == null)
            {
                return NotFound();
            }

            var newsToUpdate = await _context.News.FindAsync(id);

            if (newsToUpdate == null) { return NotFound(); }

            if (await TryUpdateModelAsync<News>(
               model: newsToUpdate,
               name: "news",
                n => n.Name, s => s.Description))
            {
                await _context.SaveChangesAsync();
                return RedirectToPage("/Home/Index");
            }
            return Page();
        }
    }
}
