using Microsoft.AspNetCore.Components;
using ShopOnline.Models.DTOs;

namespace Mark.Up.Hub.web.Pages
{
    public class DisplayProductsBase
    {
        [Parameter]
        public IEnumerable<ProductDto> Productss { get; set; }
    }
}
