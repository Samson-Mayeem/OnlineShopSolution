using Mark.Up.Hub.api.Repositories.Contracts;
using MediaBrowser.Model.Dto;
using Microsoft.AspNetCore.Mvc;
using ShopOnline.api.Repositories.Contracts;
using ShopOnline.Models.DTOs;

namespace Mark.Up.Hub.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController
    {
        private readonly IUserRepository userRepository;
        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetUsers()
        {
            try
            {
                var users = await this.userRepository.
                if (users == null)
                {
                    return NotFound();
                }
                else
                {
                    var userDto = users.ConvertToDto(users);
                    return Ok(userDto);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                                "Error retrieving data");
            }
        }

    }
}
