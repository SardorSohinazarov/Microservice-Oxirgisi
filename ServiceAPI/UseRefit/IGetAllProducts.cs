using Refit;

namespace ServiceAPI.UseRefit
{
    public interface IGetAllProducts
    {
        [Get("/api/Products/GetAllProducts")]
        Task<List<Product>> GetProducts();
    }
}
