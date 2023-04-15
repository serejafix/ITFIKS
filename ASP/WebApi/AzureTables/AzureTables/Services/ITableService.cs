using AzureTables.Models;

namespace AzureTables.Services
{
    public interface ITableService
    {
        Task<IEnumerable<Product>> GetProducts(string? category = null);
        Task<Product> GetProduct(string id,string? category = null);
        Task<Product> GetProductById(string id);
        Task<Product> UpsertProduct(Product product);
        Task DeleteProduct(string id,string category);
    }
}
