using ProgrammersInside.Web.Core.UserContext.DataInterfaces;
using ProgrammersInside.Web.Core.UserContext.Models;

namespace ProgrammersInside.Web.Database.Repositories;

public class UserRepository(ProgrammersInsideContext context) : IUserRepository
{
    private readonly ProgrammersInsideContext _context = context ?? throw new ArgumentNullException(nameof(context));

    public void AddUser(User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
    }

    public User? GetUser(string email)
    {
        return _context.Users.FirstOrDefault(x => x.Email == email);
    }

    public List<User> GetUsers()
    {
        return _context.Users.ToList();
    }
}
