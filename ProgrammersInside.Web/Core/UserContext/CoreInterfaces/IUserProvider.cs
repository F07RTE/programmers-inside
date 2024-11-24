using ProgrammersInside.Web.Core.UserContext.Models;

namespace ProgrammersInside.Web.Core.UserContext.CoreInterfaces;

public interface IUserProvider
{
    List<User> GetAllUsers();
    User? GetUser(string email);
    void AddUser(User user);
}
