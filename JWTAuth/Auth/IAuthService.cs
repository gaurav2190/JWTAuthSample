namespace JWTAUTH
{
    public interface IAuthService
    {
        Task<AuthResponse> AuthenticateAsync(string userId);
    }
}