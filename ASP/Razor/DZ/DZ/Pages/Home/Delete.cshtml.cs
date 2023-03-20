using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DZ.Models;
using DZ.Models.RazorPagesApp.Models;

namespace DZ.Pages.Home
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationContext _context;

        public DeleteModel(ApplicationContext context)
        {
            _context = context;
        }

        [BindProperty]
        public News News { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.News == null)
            {
                return NotFound();
            }
            var news = await _context.News.FindAsync(id);

            if (news != null)
            {
                News = news;
                _context.News.Remove(News);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
            //if (id == null || _context.News == null)
            //{
            //    return NotFound();
            //}

            //var news = await _context.News.FirstOrDefaultAsync(m => m.Id == id);

            //if (news == null)
            //{
            //    return NotFound();
            //}
            //else 
            //{
            //    News = news;
            //}
            //return Page();
        }

        //public async Task<IActionResult> OnPostAsync(int? id)
        //{
        //    if (id == null || _context.News == null)
        //    {
        //        return NotFound();
        //    }
        //    var news = await _context.News.FindAsync(id);

        //    if (news != null)
        //    {
        //        News = news;
        //        _context.News.Remove(News);
        //        await _context.SaveChangesAsync();
        //    }

        //    return RedirectToPage("./Index");
        //}
    }
}
