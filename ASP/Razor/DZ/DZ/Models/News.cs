﻿namespace DZ.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;

        public static implicit operator List<object>(News v)
        {
            throw new NotImplementedException();
        }
    }
}
