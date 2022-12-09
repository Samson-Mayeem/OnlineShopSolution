using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopOnline.api.Entities
{
    public class Cart
    {
        [Key]
        public long Id { get; set; }
        [ForeignKey("UserId")]
        public long UserId { get; set; }
    }
}
