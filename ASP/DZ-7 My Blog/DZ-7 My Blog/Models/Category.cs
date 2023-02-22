﻿namespace DZ_7_My_Blog.Models
{
    public class Category
    {
        public int Id { get; set; } 
        public string? Name { get; set; }
        public ICollection<Post> Posts { get; set; } = default!;
    }
}