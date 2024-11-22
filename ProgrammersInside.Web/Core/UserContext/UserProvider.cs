using ProgrammersInside.Web.Core.UserContext.DataInterfaces;
using ProgrammersInside.Web.Core.UserContext.CoreInterfaces;
using ProgrammersInside.Web.Core.UserContext.Models;

namespace ProgrammersInside.Web.Core.UserContext;

public class UserProvider : IUserProvider
{
    private IUserRepository _userRepository;

    public UserProvider(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public List<User> GetAllUsers()
    {
        return _userRepository.GetUsers();
    }
}
