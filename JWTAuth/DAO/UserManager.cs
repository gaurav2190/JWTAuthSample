namespace JWTAUTH
{
    public class UserManager : IUserManager
    {
        private readonly List<string> _users;

        public UserManager()
        {
            this._users = new List<string>{ "1234", "2345"};
        }
        
        public void Add(string userId)
        {
            this._users.Add(userId);
        }

        public bool Contains(string userId)
        {
            return _users.Contains(userId);
        }

        public List<string> GetUsers()
        {
            return this._users;
        }

        public void Remove(string userId)
        {
            this._users.Remove(userId);
        }
    }
}