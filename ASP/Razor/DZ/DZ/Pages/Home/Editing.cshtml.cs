using DZ.Models.RazorPagesApp.Models;
using DZ.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace DZ.Pages.Home
{
    public class EditingModel : PageModel
    {
        ApplicationContext _context;
        public EditingModel(ApplicationContext context)
        {
            _context = context;
        }
        public List<News> News { get; private set; } = new();

        public void OnGet()
        {
            News = _context.News.AsNoTracking().ToList();
        }
    }
}
