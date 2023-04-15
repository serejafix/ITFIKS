using AzureTables.Models;
using AzureTables.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AzureTables.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly ITableService _tableService;
        public ProductsController(ITableService tableService)
        {
           _tableService = tableService;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            var products = await _tableService.GetProducts();
            return Ok(products);
        }

        [HttpGet("{category}")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts(string category)
        {
            var product = await _tableService.GetProducts(category);
            return Ok(product);
        }

        [HttpGet("{id}/{category}")]
        public async Task<ActionResult<Product>> GetProducts(string id, string category)
        {
            var product = await _tableService.GetProduct(id, category);
            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct([FromBody]Product product)
        {
            string id = Guid.NewGuid().ToString();
            product.Id = id;
            product.RowKey = id;

            product.PartitionKey = product.Category;

            var createdProduct = await _tableService.UpsertProduct(product);

            return CreatedAtAction(nameof(GetProducts), createdProduct);
        }

        [HttpPut]
        public async Task<ActionResult<Product>> PutProduct([FromBody]Product product)
        {
            product.PartitionKey = product.Category;
            product.RowKey = product.Id;


            var UpsertProduct = await _tableService.UpsertProduct(product);
            return Ok(UpsertProduct);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(string id, string category)
        {
            await _tableService.DeleteProduct(id, category);
            return NoContent();
        }
    }
}
