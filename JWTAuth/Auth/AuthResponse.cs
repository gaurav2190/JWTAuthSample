namespace JWTAUTH
{
    public class AuthResponse
    {
        public string Token { get; set; } = string.Empty;

        public string BemsId { get; set; } = "";

        public List<UserRoles> Roles { get; set; } = new List<UserRoles>();

        public DateTime TokenExpirationTime { get; set; }
    }
}