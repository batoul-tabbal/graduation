using grade.LogIn;

namespace grade.Services
{
    public class UserServices
    {
        private readonly List<User> _users = new List<User>();

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public void DeleteUser(string username)
        {
            var user = _users.FirstOrDefault(u => u.Username == username);
            if (user != null) _users.Remove(user);
        }

        public void ResetPassword(string username, string newPassword)
        {
            var user = _users.FirstOrDefault(u => u.Username == username);
            if (user != null) user.Password = newPassword;
        }
    }

}
