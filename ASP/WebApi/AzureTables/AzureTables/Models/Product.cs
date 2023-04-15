using Azure;
using Azure.Data.Tables;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AzureTables.Models
{
    public class Product :ITableEntity
    {
        public string Id { get; set; } = default!;
        [Required]
        public string ProductName { get; set; } = default!;

        [Column(TypeName = "decimal(9,2)")]
        public decimal Price { get; set; }
        [Required]
        public string Category { get; set; } = default!;
        public string? PartitionKey { get; set; }
        public string? RowKey { get; set; }
        public DateTimeOffset? Timestamp { get; set; }
        public ETag ETag { get; set; }
    }
}
