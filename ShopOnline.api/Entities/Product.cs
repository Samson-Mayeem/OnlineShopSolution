namespace ShopOnline.api.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; } 
        public int Qty { get; set; }
        public int CategoryId { get; set; }
    }
}