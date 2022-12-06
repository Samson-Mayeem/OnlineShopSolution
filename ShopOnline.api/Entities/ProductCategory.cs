using System.ComponentModel.DataAnnotations;

namespace ShopOnline.api.Entities
{
    public class ProductCategory
    {
        [Key]
        public int Id { get; set; }
        public string ProductCategoryName { get; set; }
    }
}
