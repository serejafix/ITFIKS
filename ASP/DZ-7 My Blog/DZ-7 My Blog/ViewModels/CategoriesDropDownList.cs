using DZ_7_My_Blog.Models;

namespace DZ_7_My_Blog.ViewModels
{
    public class CategoriesDropDownList
    {
        public IEnumerable<Category> Categories { get; set; } = default!;
        public int CategoryId { get; set; }
    }
}
