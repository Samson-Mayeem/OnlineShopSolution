using System.ComponentModel.DataAnnotations;

namespace ShopOnline.api.Entities
{
    public class ProductCategory
    {
        [Key]
        public long Id { get; set; }
        public string ProductCategoryName { get; set; }
    }
}
