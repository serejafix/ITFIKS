using Blog.Models;

namespace Blog.ViewModels
{
    public class CategoriesDropDownList
    {
        public IEnumerable<Category> Categories { get; set; } = default!;
        public int CategoryId { get; set; }
    }
}
