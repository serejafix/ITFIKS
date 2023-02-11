using DZ_5.Models;
using DZ_5.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace DZ_5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHost;

        public HomeController(ILogger<HomeController> logger, AppDbContext context,
            IWebHostEnvironment webHost)
        {
            _logger = logger;
            _context = context;
            _webHost = webHost;
        }

        public IActionResult Index()
        {
            var books = _context.Books.ToList();
            return View(books);
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(BookViewModel viewModel)
        {
            string strFileName = UploadFile(viewModel);
            Book book = new Book
            {
                Name= viewModel.Name,
                Fio = viewModel.Fio,
                Style= viewModel.Style,
                Poster = strFileName,
                PublishYear =viewModel.PublishYear
            };

            _context.Books.Add(book);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        private string UploadFile(BookViewModel viewModel)
        {
            string? fileName = null;
            if(viewModel != null)
            {
                string uploadDir = Path.Combine(_webHost.WebRootPath, "Posters");
                fileName = Guid.NewGuid().ToString() + "-" + viewModel.Poster.FileName;
                string filePath = Path.Combine(uploadDir, fileName);
                using (var fs = new FileStream(filePath, FileMode.Create))
                {
                    viewModel.Poster.CopyTo(fs);                
                }
        
            }
            return fileName;
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var forView = await _context.Books.FirstOrDefaultAsync(m => m.Id == id);
            return View(forView);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}