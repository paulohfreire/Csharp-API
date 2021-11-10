using Api.Domain.Interfaces.Services.User;
using Api.Service;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependeciesService (IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IUserService, UserService>();
        }
    }
}
