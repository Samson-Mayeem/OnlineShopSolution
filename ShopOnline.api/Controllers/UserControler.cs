using Mark.Up.Hub.api.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Mark.Up.Hub.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserControler
    {
        private readonly IUserRepository UserRepository;

        public UserControler(IUserRepository userRepository) {

            this.UserRepository = userRepository;
        }
        [HttpGet]
        public async Task<ActionResult< IEnumerable<UserDto>> Get() { }

    }
}
