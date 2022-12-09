using ShopOnline.Models.DTOs;
using ShopOnline.web.Services.Contracts;
using System.Net.Http.Json;

namespace Mark.Up.Hub.web.Services
{
    public class ProductService : IProductServices
    {
        private readonly HttpClient httpClient;

        public ProductService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<ProductDto>> GetProducts()
        {
            try
            {
                var products = await this.httpClient.GetFromJsonAsync<IEnumerable<ProductDto>>("api/product");
                return products;
            }
            catch (Exception ex) {
                throw; 
                    }
        }
    }
}
