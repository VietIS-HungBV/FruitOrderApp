using System.Text.Json;
using FruitOder_20250428.Constants;

namespace FruitOder_20250428.Services
{
    public class BaseApiService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BaseApiService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        protected JsonSerializerOptions DefaultSerializerOptions = new()
        {
            PropertyNameCaseInsensitive = true
        };

        protected HttpClient HttpClient => _httpClientFactory.CreateClient(AppConstants.HttpClientName);

        protected TData Deseriallize<TData>(string jsonData) =>
            JsonSerializer.Deserialize<TData>(jsonData, DefaultSerializerOptions);

        protected async Task<TData> HandlerApiResponseAsync<TData>(HttpResponseMessage response, TData defaultValue)
        {
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(content))
                {
                    return Deseriallize<TData>(content);
                }
            }
            return defaultValue;
        }
    }
}
