using Mark.Up.Hub.api.Repositories.Contracts;
using MediaBrowser.Model.Dto;
using Microsoft.AspNetCore.Mvc;
using ShopOnline.api.Extentions;
using ShopOnline.api.Repositories.Contracts;
using ShopOnline.Models.DTOs;
using System.Security.Cryptography.X509Certificates;

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
        public async Task<IActionResult> GetAll()
        { 
        var user = await this.userRepository.GetUsers();
            try {

                if (user == null)
                { 
                    return NotFound();
                }
                else
                {
                    var userdto = user.ConvertUserToDto();
                    return Ok(userdto);
                }
            catch(Exception ex) { }
            return user;
        }
    }
}
