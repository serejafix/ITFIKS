﻿namespace DZ_7_My_Blog.Models
{
    public class PostImage
    {
        public int Id { get; set; }
        public byte[] Image { get; set; } = default!;
        public string? Description { get; set; }
        public int PostId { get; set; }
        public Post? Post { get; set; }
    }
}