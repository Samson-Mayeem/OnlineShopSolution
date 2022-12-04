using Mark.Up.Hub.api.Repositories.Contracts;
using MediaBrowser.Model.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Mark.Up.Hub.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController
    {
        private readonly IUserRepository UserRepository;

        public UserController(IUserRepository userRepository) {

            this.UserRepository = userRepository;
        }
        [HttpGet]
        public async Task<ActionResult< IEnumerable<UserDto>> Get() { }

    }
}
