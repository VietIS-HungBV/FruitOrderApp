using FruitOder.Shared.Dtos;
using FruitOder_20250428.Models;

namespace FruitOder_20250428.Services
{
    public class ProductsService : BaseApiService
    {
        public ProductsService(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }
        public async Task<IEnumerable<ProductDto>> GetPopularProductsAsync()
        {
            var response = await HttpClient.GetAsync("$/popular-products");
            return await HandlerApiResponseAsync(response, Enumerable.Empty<ProductDto>());
        }
    }
}
