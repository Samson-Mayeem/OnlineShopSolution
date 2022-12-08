using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.Models.DTOs
{
    public class CartItemQtyUpdateDto
    {
        public long CartItemId { get; set; }
        public int Qty { get; set;}
    }
}
