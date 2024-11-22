using ProgrammersInside.Web.Core.UserContext;
using ProgrammersInside.Web.Core.UserContext.CoreInterfaces;

namespace ProgrammersInside.Web.Core;

public static class ProgrammersInsideCoreDependencyConfig
{
    public static void AddProgrammersInsideCoreDependencyConfig(this IServiceCollection services)
    {
        services.AddScoped<IUserProvider, UserProvider>();
    }
}
