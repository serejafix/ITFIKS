using DZ.Models;
using DZ.Models.RazorPagesApp.Models;
using DZ.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NuGet.Packaging;

namespace DZ.Pages.Home
{
    [IgnoreAntiforgeryToken]
    public class CreateModel : PageModel
    {
        ApplicationContext context;

        [BindProperty]
        public News News { get; set; } = new();
        //public NewsBookModel NewsBookModel { get; set; } = new();

        public CreateModel(ApplicationContext db)
        {
            context = db;
        }
        public IActionResult OnGetComment() => Partial("_AddCommentPartial");

        public async Task<IActionResult> OnPostAsync()
        {

            var emptyNews = new News();
            if (await TryUpdateModelAsync<News>(
                emptyNews,
                "",
                n => n.Name, n => n.Description))
            {
                context.News.Add(emptyNews);
                await context.SaveChangesAsync();
                return RedirectToAction("/Home/Index");
            }
            return Page();
        }
    }
}
