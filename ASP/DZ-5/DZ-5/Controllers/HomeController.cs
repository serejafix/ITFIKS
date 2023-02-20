using DZ_5.Models;
using DZ_5.ViewModels;
using Microsoft.AspNetCore.Authorization;
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

        [HttpPost]
        public IActionResult Index(string name,DateTime? date,string style,string fio)
        {
            var result = _context.Books.Where(s => s.Name.Contains(name) || name == null)
                                       .Where(s => s.Style.Contains(style) || style == null)
                                       .Where(s=> s.PublishYear == date||  date == null)
                                       .Where(s=> s.Fio == fio || fio == null)
                                       .ToList();
            return View(result);
        }
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }
        [Authorize]
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
        [Authorize]
        public IActionResult Delete(int?id)
        {
            if (id == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting data");
            }

            var bookForDelete = _context.Books.FirstOrDefault(i => i.Id == id);

            return View(bookForDelete);
        }
        [Authorize]
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null) { return NotFound(); }

            
            var forView = await _context.Books.FirstOrDefaultAsync(m => m.Id == id);
            if (forView != null)
                _context.Books.Remove(forView);
                _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) { return NotFound(); } 

            var forView = await _context.Books.FirstOrDefaultAsync(m => m.Id == id);

            return View(forView);
        }
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) { return NotFound(); }

            var book = await _context.Books.FindAsync(id); // Getting member by Id from database
            return View(new BookViewModelEdit() { Book = book });
        }
        [Authorize]
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