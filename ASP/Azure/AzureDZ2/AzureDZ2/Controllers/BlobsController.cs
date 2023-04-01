using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AzureDZ2.Models;
using Azure.Storage.Blobs;
using Microsoft.CodeAnalysis.Differencing;

namespace AzureDZ2.Controllers
{
    public class BlobsController : Controller
    {
        private readonly BlobContext _context;
        private readonly IConfiguration _configuration;
        private readonly BlobServiceClient _blobServiceClient;
        private readonly string _AzureContainerName;
        public BlobsController(BlobContext context, BlobServiceClient blobServiceClient,
            IConfiguration configuration)
        {
            _blobServiceClient = blobServiceClient;
            _configuration = configuration;
            _context = context;
            _AzureContainerName = _configuration.GetSection("Azure:BlobContainerName").Value;
        }

        // GET: Blobs
        public async Task<IActionResult> Index()
        {

              return _context.Blobs != null ? 
                          View(await _context.Blobs.ToListAsync()) :
                          Problem("Entity set 'BlobContext.Blob'  is null.");
        }

        // GET: Blobs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Blobs == null)
            {
                return NotFound();
            }

            var blob = await _context.Blobs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blob == null)
            {
                return NotFound();
            }

            return View(blob);
        }

        // GET: Blobs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Blobs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateVM createVM)
        {
            if (ModelState.IsValid == false)
                return View(createVM);

            string FileName = Guid.NewGuid().ToString() + createVM.Image.FileName;


            BlobContainerClient blobContainerClient = _blobServiceClient.GetBlobContainerClient(_AzureContainerName);
            await blobContainerClient
                .CreateIfNotExistsAsync();
            await blobContainerClient.SetAccessPolicyAsync
                (Azure.Storage.Blobs.Models.PublicAccessType.BlobContainer);
            BlobClient blobClient = blobContainerClient.GetBlobClient(FileName);
            Stream imageStream = createVM.Image.OpenReadStream();
            await blobClient.UploadAsync(imageStream);

            Blob blobToAdd = new Blob()
            {
                FileName = FileName,
                Uri = blobClient.Uri.AbsoluteUri
            };

            await _context.Blobs.AddAsync(blobToAdd);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        // GET: Blobs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Blobs == null)
            {
                return NotFound();
            }

            var blob = await _context.Blobs.FindAsync(id);
            if (blob == null)
            {
                return NotFound();
            }
            return View(blob);
        }

        // POST: Blobs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, EditVM editVM)
        {
            if (id != editVM.Blob.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid == false)
            {
                return View(editVM);
            }
            if (editVM.Image is null)
            {
                return RedirectToAction(nameof(Index));
            }
            string FileName = Guid.NewGuid().ToString() + editVM.Image.FileName;

            BlobContainerClient blobContainerClient = _blobServiceClient.GetBlobContainerClient(_AzureContainerName);
            await blobContainerClient
                .CreateIfNotExistsAsync();

            await blobContainerClient.SetAccessPolicyAsync
                (Azure.Storage.Blobs.Models.PublicAccessType.BlobContainer);

            BlobClient blobClientToDelete = blobContainerClient.GetBlobClient(editVM.Blob.FileName);
            await blobClientToDelete.DeleteIfExistsAsync();

            BlobClient blobClient = blobContainerClient.GetBlobClient(FileName);
            Stream imageStream = editVM.Image.OpenReadStream();
            await blobClient.UploadAsync(imageStream);
            editVM.Blob.FileName = FileName;
            editVM.Blob.Uri = blobClient.Uri.AbsoluteUri;
            _context.Blobs.Update(editVM.Blob);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        // GET: Blobs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Blobs == null)
            {
                return NotFound();
            }

            var blob = await _context.Blobs
                .FindAsync(id);
            if (blob == null)
            {
                return NotFound();
            }

            return View(blob);
        }

        // POST: Blobs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Blobs == null)
            {
                return Problem("Entity set 'BlobContext.Blob'  is null.");
            }
            var blob = await _context.Blobs.FindAsync(id);

            if (blob == null)
            {
                return NotFound();
            }

            BlobContainerClient blobContainerClient =
                _blobServiceClient.GetBlobContainerClient(_AzureContainerName);

            BlobClient blobClientToDelete = blobContainerClient.GetBlobClient(blob.FileName);

            await blobClientToDelete.DeleteIfExistsAsync();

            _context.Blobs.Remove(blob);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        private bool BlobExists(int id)
        {
          return (_context.Blobs?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
