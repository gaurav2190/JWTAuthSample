namespace JWTAUTH
{
    public interface IUserManager
    {
        void Add(string userId);

        void Remove(string userId);

        bool Contains(string userId);

        List<string> GetUsers();
    }
}