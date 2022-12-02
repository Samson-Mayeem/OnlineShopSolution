using ShopOnline.api.Entities;
using ShopOnline.Models.DTOs;

namespace ShopOnline.api.Extentions
{
    public static class DtoConversions
    {
        public static IEnumerable<Models.DTOs.ProductDto>
            ConvertToDto(this IEnumerable<Product> Products,
                              IEnumerable<ProductCategory> productCategories)
        {
            return (from Product in Products
                    join ProductCategory in productCategories
                    on Product.CategoryId equals ProductCategory.Id
                    select new ProductDto
                    {
                      Id = ProductCategory.Id,
                      Name = Product.ProductName,
                      Description = Product.Description,
                      ImageURL = Product.ImageUrl,
                      Price = Product.Price,
                      Qty = Product.Qty,
                      CategoryId = Product.CategoryId,
                      CategoryName = Product.ProductName         
                    }).ToList();
        }
    }
}
