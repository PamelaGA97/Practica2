using Microsoft.AspNetCore.Http;
using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserManager _userManager;
        public UsersController(IUserManager userManager)
        {
            userManager = userManager;
        }
        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(_userManager.GetUsers());
        }
        [HttpPost]
        public IActionResult PostUser(User user)
        {
            return Ok(_userManager.PostUsers(user));
        }
        [HttpDelete]
        public IActionResult DeleteUser(User user)

        {
            return Ok();
        }
        [HttpPut]
        public IActionResult PutUser(User user)
        {
            return Ok();
        }
    }
}
