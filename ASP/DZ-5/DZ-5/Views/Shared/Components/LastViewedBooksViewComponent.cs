using DZ_5.Extension;
using DZ_5.Models;
using Microsoft.AspNetCore.Mvc;

namespace DZ_5.Views.Shared.Components
{
    public class LastViewedBooksViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<Book> sessionBooks = new List<Book>();

            foreach (var key in HttpContext.Session.Keys.Where(k=> k.Contains("LastViewedBooks")))
            {
                sessionBooks.Add(HttpContext.Session.Get<Book>(key)!);
            }
            return View(sessionBooks);
        }
    }
}
