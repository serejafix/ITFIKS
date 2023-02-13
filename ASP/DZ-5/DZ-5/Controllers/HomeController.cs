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
            string strFileName = UploadFile(viewModel.Poster);
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

        private string UploadFile(IFormFile formFile)
        {
            string? fileName = null;
            if (formFile != null)
            {
                string uploadDir = Path.Combine(_webHost.WebRootPath, "Posters");
                fileName = Guid.NewGuid().ToString() + "-" + formFile.FileName;
                string filePath = Path.Combine(uploadDir, fileName);
                using (var fs = new FileStream(filePath, FileMode.Create))
                {
                    formFile.CopyTo(fs);
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
            if (id == null) { return NotFound(); } 

            var forView = await _context.Books.FirstOrDefaultAsync(m => m.Id == id);

            return View(forView);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) { return NotFound(); }

            var book = await _context.Books.FindAsync(id); // Getting member by Id from database
            return View(new BookViewModelEdit() { Book = book });
        }
        [HttpPost]
        public async Task<IActionResult> Edit(BookViewModelEdit bookViewModelEdit,int?id)
        {

            if (id == null) { return NotFound(); }
            string strFileName = UploadFile(bookViewModelEdit.Poster);
            bookViewModelEdit.Book.Poster = strFileName;
            var book = await _context.Books.FirstOrDefaultAsync(m => m.Id == id);
            if(book == null) { return NotFound(); }
            _context.Remove(book);
            _context.Books.Add(bookViewModelEdit.Book);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}