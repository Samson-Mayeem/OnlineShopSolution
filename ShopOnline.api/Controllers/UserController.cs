using Mark.Up.Hub.api.Repositories.Contracts;
using MediaBrowser.Model.Dto;
using Microsoft.AspNetCore.Mvc;
using ShopOnline.api.Entities;
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
        List<User> use;
        /*[HttpGet]
        public async Task<IActionResult> GetAll()
        { 
             foreach(var user in use)
            {
                if(user == null)
                {
                    
                }
            }
            return await user;*/
    }
}
