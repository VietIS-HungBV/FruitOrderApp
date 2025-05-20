using FruitOder_20250428.Models;

namespace FruitOder_20250428.Services
{
    public class OffersService : BaseApiService
    {
        public OffersService(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }
        public async Task<IEnumerable<Offer>> GetActiveOffersAsync()
        {
            var response = await HttpClient.GetAsync("/masters/offers");
            return await HandlerApiResponseAsync(response, Enumerable.Empty<Offer>());
        }
    }
}
