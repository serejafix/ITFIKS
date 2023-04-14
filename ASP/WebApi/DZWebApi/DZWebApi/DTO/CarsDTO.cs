using System.ComponentModel.DataAnnotations;

namespace DZWebApi.DTO
{
    public class CarsDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Model { get; set; } = default!;

        public DateTime DataCreate { get; set; } = default!;

        public string Color { get; set; } = default!;

        public double Price { get; set; } = default!;
    }
}
