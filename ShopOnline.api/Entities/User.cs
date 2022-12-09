using System.ComponentModel.DataAnnotations;

namespace ShopOnline.api.Entities
{
    public class User
    {
        [Key]
        public long UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string Password { get; set; }
        public string ImageUrl { get; set; }
    }
}