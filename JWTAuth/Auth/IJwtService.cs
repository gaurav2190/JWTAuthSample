namespace JWTAUTH
{
    public interface IJwtService
    {
        Task<string> GenerateToken(string userId, DateTime expirationDateTime);
    }
}