﻿using System.Text.Json;
using FruitOder_20250428.Models;

namespace FruitOder_20250428.Services
{

    public class CategoryService : BaseApiService
    {
        public CategoryService(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }
        private IEnumerable<Category>? _categories;

        public async ValueTask<IEnumerable<Category>> GetCategoriesAsync()
        {
            if (_categories is null)
            {
                var response = await HttpClient.GetAsync("/masters/categories");
                var categories = await HandlerApiResponseAsync<IEnumerable<Category>>(response, null);
                if (categories is null)
                    return Enumerable.Empty<Category>();
                _categories = categories;
            }
            return _categories;
        }

        public async ValueTask<IEnumerable<Category>> GetMainCategoriesAsync() =>
            (await GetCategoriesAsync()).Where(c => c.ParentId == 0);
    }
}
