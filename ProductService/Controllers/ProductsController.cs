using Microsoft.AspNetCore.Mvc;

namespace ProductService.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ProductsController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Sardor", "Sardor", "Sardor", "Sardor", "Sardor"
        };

        [HttpGet]
        public IEnumerable<Product> GetAllProducts()
        {
            return Enumerable.Range(1, 5).Select(index => new Product
            {
                Id = new Random().Next(1,5),
                Name = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
