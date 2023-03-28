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
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http.HttpResults;

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
        public Comment Comment { get; set; } = new();
        [BindProperty]
        public DetailsViewModel DetailsVM { get; set; } = new();
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
        public  ActionResult OnPostDelete(int? id)
        {
            var commentToDelete =  _context.Comments.FirstOrDefault(s => s.Id == id);
            if (commentToDelete == null)
            {
                return NotFound();
            }
            
            _context.Comments.Remove(commentToDelete);
             _context.SaveChangesAsync(); 
            return RedirectToPage("./Details", new { id = commentToDelete.NewsId });
        }

        public ActionResult OnPostEdit(int? id,string text)     
        {
            if (id == null || _context.News == null)
            {
                return NotFound();
            }
            var commentToUpdate = _context.Comments.FirstOrDefault(s => s.Id == id);
          
            if (commentToUpdate == null) { return NotFound(); }
            commentToUpdate.Text = text;
            _context.Comments.Update(commentToUpdate);
            _context.SaveChanges();
            return RedirectToPage("./Details", new { id = commentToUpdate.NewsId });
        }

        private bool TryUpdateModel<T>(News model, string name, Func<object, object> value1, Func<object, object> value2)
        {
            throw new NotImplementedException();
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
            return RedirectToPage("./Details", new { id = news.Id });
        }
    }
}
