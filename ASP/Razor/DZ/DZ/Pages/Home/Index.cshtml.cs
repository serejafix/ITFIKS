using DZ.Models;
using DZ.Models.RazorPagesApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace DZ.Pages.Home
{
    public class IndexModel : PageModel
    {
         ApplicationContext _context;
        public List<News> News { get; private set; } = new();

        public IndexModel(ApplicationContext db)
        {
            _context = db;
        }
        public void OnGet()
        {
            News = _context.News.AsNoTracking().ToList();
        }
    }
}
