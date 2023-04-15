using Azure;
using Azure.Data.Tables;
using AzureTables.Models;

namespace AzureTables.Services
{
    public class TableService : ITableService
    {
        private readonly string _tableName = "ProductsTable";

        private readonly string _connectionString;
        private readonly ILogger<TableService>? _logger;
        public TableService(IConfiguration configuration,ILogger<TableService> logger) 
        {
            _connectionString = configuration.GetSection("AzureStorageConnectionString").Value;
            _logger = logger;
        }

        private async Task<TableClient> GetTableClientAsync()
        {
            TableServiceClient tableServiceClient
                = new TableServiceClient(_connectionString);

            TableClient tableClient = tableServiceClient.GetTableClient(_tableName);
            await tableClient.CreateIfNotExistsAsync();

            return tableClient;
        }
        public async Task<IEnumerable<Product>> GetProducts(string? category = null)
        {
            TableClient tableClient = await GetTableClientAsync();

            AsyncPageable<Product> results;
            if (category == null)
            {
                results = tableClient.QueryAsync<Product>();
            }
            else
            {
                results = tableClient.QueryAsync<Product>(p => p.PartitionKey == category);
            }

            IList<Product> products = new List<Product>();
            await foreach (Product product in results)
            {
                products.Add(product);
            }
            return products;
        }

        public async Task<Product> GetProduct(string id, string? category = null)
        {
            TableClient tableClient = await GetTableClientAsync();

            var product = await tableClient.GetEntityAsync<Product>(category, id);

            return product;
        }

        public Task<Product> GetProductById(string id)
        {
            throw new NotImplementedException();
        }

        public async  Task<Product> UpsertProduct(Product product)
        {
            TableClient tableClient = await GetTableClientAsync();

            var responce = await tableClient.UpsertEntityAsync<Product>(product);
            _logger!.LogInformation($"Responce {responce.Status}");

            return product;
        }
        public async Task DeleteProduct(string id, string category)
        {
            TableClient tableClient = await GetTableClientAsync();

            await tableClient.DeleteEntityAsync(category, id);
        }
    }
}
