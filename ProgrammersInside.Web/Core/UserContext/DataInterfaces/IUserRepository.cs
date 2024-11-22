using ProgrammersInside.Web.Core.UserContext.Models;

namespace ProgrammersInside.Web.Core.UserContext.DataInterfaces;

public interface IUserRepository
{
    void AddUser(User user);
    User GetUser(string email);
    List<User> GetUsers();
}
