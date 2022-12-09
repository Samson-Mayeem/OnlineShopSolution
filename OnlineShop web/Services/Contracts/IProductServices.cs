using ShopOnline.Models.DTOs;

namespace ShopOnline.web.Services.Contracts
{
    public interface IProductServices
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
