using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Refit;
using ServiceAPI.UseRefit;

namespace ServiceAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    //[Authorize]
    public class GetProductsFromServiceAPIController : ControllerBase
    {
        [HttpGet]
        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            var productAPI = RestService.For<IGetAllProducts>("http://productservice:80");
            var products = await productAPI.GetProducts();
            return products;
        }
    }
}
