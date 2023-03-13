﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Blog.Models;
using Blog.ViewModels;
using Blog.ViewModels.NavigationViewModels;

namespace Blog.Controllers
{
    public class PostsController : Controller
    {
        private readonly AppDbContext _context;

        public PostsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Posts
        public async Task<IActionResult> Index(int categoryId, string? search, int page = 1,
            SortState sortOrder = SortState.TitleAsc)
        {
            int pageSize = 3;

            IQueryable<Post> posts = _context.Posts
                .Include(p => p.Category)
                .Include(p => p.User)
                .AsNoTracking<Post>();

            if (categoryId != 0)
            {
                posts = posts.Where(p => p.Category!.Id == categoryId);
            }
            if (!string.IsNullOrEmpty(search))
            {
                posts = posts.Where(p => p.Title.Contains(search));
            }

            switch (sortOrder)
            {
                case SortState.TitleDesc:
                    posts = posts.OrderByDescending(p => p.Title);
                    break;

                case SortState.DescriptionAsc:
                    posts = posts.OrderBy(p => p.Description);
                    break;
                case SortState.DescriptionDesc:
                    posts = posts.OrderByDescending(p => p.Description);
                    break;

                case SortState.CategoryAsc:
                    posts = posts.OrderBy(p => p.Category!.Name);
                    break;
                case SortState.CategoryDesc:
                    posts = posts.OrderByDescending(p => p.Category!.Name);
                    break;

                case SortState.CreatedAsc:
                    posts = posts.OrderBy(p => p.Created);
                    break;
                case SortState.CreatedDesc:
                    posts = posts.OrderByDescending(p => p.Created);
                    break;

                default:
                    posts = posts.OrderBy(p => p.Title);
                    break;
            }


            int postsCount = await posts.CountAsync();

            var postItems = await posts.Skip((page -1) * pageSize)
                .Take(pageSize).ToListAsync();

           List<Category> categories = await _context.Categories.ToListAsync();

            PostViewModel postViewModel = new PostViewModel(
                postItems,
                new FilterVM(categories, categoryId, search),
                new SortVM(sortOrder),
                new PageVM(postsCount, page, pageSize));
           
            return View(postViewModel);
        }

        // GET: Posts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Posts == null)
            {
                return NotFound();
            }

            var post = await _context.Posts
                .Include(p => p.Category)
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        // GET: Posts/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Id");
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Posts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,Body,Created,MainPostImage,IsDeleted,CategoryId,UserId")] Post post)
        {
            if (ModelState.IsValid)
            {
                _context.Add(post);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Id", post.CategoryId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", post.UserId);
            return View(post);
        }

        // GET: Posts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Posts == null)
            {
                return NotFound();
            }

            var post = await _context.Posts.FindAsync(id);
            if (post == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Id", post.CategoryId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", post.UserId);
            return View(post);
        }

        // POST: Posts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,Body,Created,MainPostImage,IsDeleted,CategoryId,UserId")] Post post)
        {
            if (id != post.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(post);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PostExists(post.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Id", post.CategoryId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", post.UserId);
            return View(post);
        }

        // GET: Posts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Posts == null)
            {
                return NotFound();
            }

            var post = await _context.Posts
                .Include(p => p.Category)
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        // POST: Posts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Posts == null)
            {
                return Problem("Entity set 'AppDbContext.Posts'  is null.");
            }
            var post = await _context.Posts.FindAsync(id);
            if (post != null)
            {
                _context.Posts.Remove(post);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PostExists(int id)
        {
          return (_context.Posts?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
