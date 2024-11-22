using ProgrammersInside.Web.Core.UserContext.DataInterfaces;
using ProgrammersInside.Web.Database.Repositories;

namespace ProgrammersInside.Web.Database;

public static class ProgrammersInsideDataDependencyConfig
{
    public static void AddProgrammersInsideDataDependencyConfig(this IServiceCollection services)
    {
        services.AddScoped<IUserRepository, UserRepository>();
    }
}
