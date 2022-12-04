using Microsoft.EntityFrameworkCore;
using ShopOnline.api.Entities;
using ShopOnline.api;
using ShopOnline.api.Repositories.Contracts;
using Mark.Up.Hub.api.Data;

namespace ShopOnline.api.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext dataContext;

        public ProductRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        
        public async Task<IEnumerable<Product>> GetItems()
        {
            var products = await this.dataContext.Products.ToListAsync();
            return products;
        }
        public async Task<IEnumerable<ProductCategory>> GetCategories()
        {
            var categories = await this.dataContext.ProductCategory.ToListAsync();
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

        

        public Task<Product> GetProduct(int id)
        {
            throw new NotImplementedException();
        }
    }
}
