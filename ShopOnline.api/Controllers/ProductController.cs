using Microsoft.AspNetCore.Mvc;
using ShopOnline.api.Extentions;
using ShopOnline.api.Repositories.Contracts;
using ShopOnline.Models.DTOs;

namespace ShopOnline.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    { 
        private readonly IProductRepository productRepository;  
        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository; 
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetItems()
        {
           try 
            {   var products = await this.productRepository.GetItems();
                var productCategories = await this.productRepository.GetCategories();
                if(products == null || productCategories == null)
                {
                    return NotFound();
                }
                else
                {
                    var productDto = products.ConvertProductToDto(productCategories);
                    return Ok(productDto);
                }
            }
            catch(Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                                "Error retrieving data");
            }        
        }
    }
}
