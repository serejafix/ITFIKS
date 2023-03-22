using Microsoft.Extensions.Hosting;
using System.Runtime.CompilerServices;

namespace DZ.Models.RazorPagesApp.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public IEnumerable<Comment>? Comments { get; set; }
    }
}