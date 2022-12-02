using Microsoft.EntityFrameworkCore;
using ShopOnline.api.Entities;
using Mark.Up.Hub.api.Data;
using ShopOnline.api.Repositories.Contracts;

namespace ShopOnline.api.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IProductRepository _repository;

        public ProductRepository(HubContext hubContext)
        {
            this.hubContext = hubContext;
        }
        public async Task<IEnumerable<ProductCategory>> GetCategories()
        {
            var categories = await this.hubDbContext.ProductCategory.ToListAsync();
            return categories;
        }

        public Task<ProductCategory> GetCategory(int id)
        {
            return GetCategory(id);
        }

        public Task<Product> GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
           var products = await this.hubDbContext.Products.ToListAsync();
            return products;
        }

        public Task<Product> GetProduct(int id)
        {
            throw new NotImplementedException();
        }
    }
}
