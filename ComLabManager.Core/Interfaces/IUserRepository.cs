
using ComLabManager.Core.Models;

namespace ComlabManager.Core.Interfaces
{
    public interface IUserRepository
    {
        User AuthenticateUser(string username, string rawPassword);
        List<User> GetUsersByRole(string role);
    }
}