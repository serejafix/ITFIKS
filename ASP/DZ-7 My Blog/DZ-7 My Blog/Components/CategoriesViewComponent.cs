using Blog.Models;
using Blog.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Blog.Components
{
    public class CategoriesViewComponent :ViewComponent
    {
        private readonly AppDbContext _context;
        public CategoriesViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            IQueryable<Category> categories = _context.Categories;
            int categoryId = 0;

            if (Request.Query.ContainsKey("categoryId"))
            {
                int.TryParse(Request.Query["categoryId"].ToString(), out categoryId);
            }

            CategoriesDropDownList viewModel = new CategoriesDropDownList
            {
                Categories = await categories.ToListAsync(),
                CategoryId= categoryId
            };
            return View(viewModel);
        }
    }
}
