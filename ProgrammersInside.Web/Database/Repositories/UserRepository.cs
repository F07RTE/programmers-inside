using ProgrammersInside.Web.Core.UserContext.DataInterfaces;
using ProgrammersInside.Web.Core.UserContext.Models;

namespace ProgrammersInside.Web.Database.Repositories;

public class UserRepository : IUserRepository
{
    private readonly ProgrammersInsideContext _context = null!;

    public void AddUser(User user)
    {
        _context.Users.Add(user);
    }

    public User GetUser(string email)
    {
        return _context.Users.Single(x => x.Email == email);
    }

    public List<User> GetUsers()
    {
        return _context.Users.ToList();
    }
}
