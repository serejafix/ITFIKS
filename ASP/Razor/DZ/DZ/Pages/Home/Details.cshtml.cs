using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DZ.Models;
using DZ.Models.RazorPagesApp.Models;
using DZ.ViewModels;
using System.Xml.Linq;
namespace DZ.Pages.Home
{
    public class DetailsModel : PageModel
    {
        private readonly ApplicationContext _context;

        public DetailsModel(ApplicationContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DetailsViewModel DetailsVM { get; set; } = new();
        //public News News { get; set; } = new();
        [BindProperty]
        public Comment Comment { get; set; } = new();
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.News == null)
            {
                return NotFound();
            }

            var news = await _context.News.FirstOrDefaultAsync(m => m.Id == id);

            var comments = await _context.Comments.ToListAsync();

            var commentsForThisNews = comments.Where(a => a.NewsId == id).ToList();

            if (news == null && comments == null)
            {
                return NotFound();
            }
            else if (comments == null)
            {
                DetailsVM = new DetailsViewModel()
                {
                    News = new List<News>()
                    {
                        news!
                    }
                };
            }
            else
            {
                DetailsVM = new DetailsViewModel()
                {
                    News = new List<News>()
                    {
                        news!
                    },
                    Comments = commentsForThisNews
                };
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int? Id)
        {
            if (Id == null || _context.News == null)
            {
                return NotFound();
            }

            var news = await _context.News.FirstOrDefaultAsync(m => m.Id == Id);

            if (news == null)
            {
                return NotFound();
            }

            var comment = new Comment()
            {
                NewsId = news!.Id,
                Text = Comment.Text
             };

            if (comment == null)
            {
                return NotFound();
            }
            _context.Comments.Add(comment);
            await _context.SaveChangesAsync();
            return Page();
        }
    }
}
