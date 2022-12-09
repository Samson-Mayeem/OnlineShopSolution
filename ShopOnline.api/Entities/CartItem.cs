using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopOnline.api.Entities
{
    public class CartItem
    {
        [Key]
        public long Id { get; set; }
        [ForeignKey("CartId")]
        public int CartId { get; set; }
        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
        public int Qty { get; set; }
    }
}
