﻿using Blog.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModels.NavigationViewModels
{
    public class FilterVM
    {
        public FilterVM(List<Category> categories, int categoryId, string? search)
        {
            categories.Insert(0, new Category { Name = "All Categories", Id = 0 });
            CategoriesSL = new SelectList(categories, "Id", "Name", categoryId);
            CategoryId = categoryId;
            Search = search;
        }
        [Display(Name = "Categories")]
        public SelectList CategoriesSL { get; set; }
        public int CategoryId { get; set; }
        public string? Search { get; set; }

    }
}
