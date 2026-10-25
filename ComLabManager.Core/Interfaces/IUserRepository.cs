using ComLabManager.Core.Models;
using System.Collections.Generic;

namespace ComLabManager.Core.Interfaces
{
    public interface IUserRepository
    {
        User AuthenticateUser(string username, string rawPassword);
        List<User> GetUsersByRole(string role);

        IEnumerable<User> GetAllUsers();
        void AddUser(User user, string rawPassword);
        void UpdateUser(User user, string rawPassword);
        void DeleteUser(int id);
    }
}