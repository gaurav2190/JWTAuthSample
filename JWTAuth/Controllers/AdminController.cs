using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JWTAUTH
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly IUserManager userManager;
        public AdminController(IUserManager userManager)
        {
            this.userManager = userManager;
        }

        [HttpPost("AddUser")]
        [Authorize(Roles = "Admin")]
        public IActionResult AddUser([FromBody]string userId)
        {
            this.userManager.Add(userId);

            return Ok();
        }

        [HttpGet("GetUsers")]
        public IActionResult GetUsers()
        {
            var users = this.userManager.GetUsers();

            return Ok(users);
        } 
    }
}