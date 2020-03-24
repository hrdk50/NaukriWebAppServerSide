using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NaukriWebApp.Models;
using NaukriWebApp.Domain;
using Microsoft.AspNetCore.Mvc;

namespace NaukriWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        public UsersController()
        {
            this.UserDomain = new UserDomain(); 
        }



        [HttpPost]
        public IActionResult Post(User user)
        {
            var isLoggedIn = this.UserDomain.IsLogin(user);
            return Ok(isLoggedIn);
        }

        public UserDomain UserDomain { get; set; }
    }
}
