using Microsoft.AspNetCore.Components;
using ShopOnline.Models.DTOs;
using ShopOnline.web.Services.Contracts;

namespace Mark.Up.Hub.web.Pages
{
    public class ProductsBase: ComponentBase
    {
        [Inject]
        public IProductServices ProductServices { get; set; }
        public IEnumerable<ProductDto> Products { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Products = await ProductServices.GetProducts();
        }
    }
}
