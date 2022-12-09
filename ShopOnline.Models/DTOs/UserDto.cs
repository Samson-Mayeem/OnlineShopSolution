using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mark.Up.Hub.Models.DTOs
{
    public class UserDto
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string Password { get; set; }
        public string ImageUrl { get; set; }
    }
}
