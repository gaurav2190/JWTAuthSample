using Microsoft.AspNetCore.Mvc;

namespace JWTAUTH
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService authService;

        public AuthController(IAuthService authService)
        {
            this.authService = authService;
        }

        [HttpPost("Authenticate")]
        public async Task<IActionResult> Authenticate([FromBody]string userId)
        {
            var userInfo = await this.authService.AuthenticateAsync(userId);

            return Ok(new {
                UserId = userId,
                Token = userInfo.Token,
                TokenExpirationTime = userInfo.TokenExpirationTime                
            });
        }
    }
}