using Microsoft.AspNetCore.Mvc;

namespace ClothingStore.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private static List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "T-Shirt", Price = 20 },
            new Product { Id = 2, Name = "Hoodie", Price = 50 }
        };

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(products);
        }

        [HttpPost]
        public IActionResult Add(Product product)
        {
            products.Add(product);
            return Ok(products);
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}