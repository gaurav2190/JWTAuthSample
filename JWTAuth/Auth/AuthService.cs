
using Microsoft.Extensions.Options;

namespace JWTAUTH
{
    public class AuthService : IAuthService
    {
        private readonly IJwtService _jwtService;

        private readonly JwtSettings jwtSettings;

        private readonly IUserManager _userRepository;

        public AuthService(IJwtService jwtService, IUserManager userRepository, IOptions<JwtSettings> jwtSettings)
        {
            _jwtService = jwtService;
            _userRepository = userRepository;
            this.jwtSettings = jwtSettings.Value;
        }

        public async Task<AuthResponse> AuthenticateAsync(string userId)
        {
            // Replace below logic with Indentity provider code to check for the user credentials or account.
            if(!this._userRepository.Contains(userId))
            {
                throw new UnauthorizedAccessException("Invalid user id"); 
            }

            var expirationDateTime = DateTime.Now.AddMinutes(this.jwtSettings.ExpirationInMinutes);

            var token = await this._jwtService.GenerateToken(userId, expirationDateTime);
            
            return new AuthResponse{
                Token = token,
                BemsId = userId,
                Roles = new List<UserRoles> { UserRoles.Admin },
                TokenExpirationTime = expirationDateTime
            };
        }
    }
}