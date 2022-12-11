using Microsoft.AspNetCore.Components;
using ShopOnline.Models.DTOs;
using ShopOnline.web.Services.Contracts;

namespace Mark.Up.Hub.web.Pages
{
    public class ProductsBase : ComponentBase
    {
        [Inject]
        public IProductServices ProductServices { get; set; }
        public IEnumerable<ProductDto> Products { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Products = await ProductServices.GetProducts();
        }
        protected IOrderedEnumerable<IGrouping<int, ProductDto>> GetGroupedProductsByCategory()
        {
            return from product in Products
                   group product by product.CategoryId into prodGroupByCatGroup
                   orderby prodGroupByCatGroup.Key
                   select prodGroupByCatGroup;
        }
        protected string GetCategoryName(IGrouping<int, ProductDto> GroupedPDtoroduct) {
            return GroupedPDtoroduct.FirstOrDefault(pg => pg.CategoryId == GroupedPDtoroduct.Key).CategoryName;

        }
    }
}
