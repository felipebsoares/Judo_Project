using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProjetoJudo.Infra.Context;

namespace ProjetoJudo.Infra;

public static class Injection
{
    public static void ConfigureDataBase(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        serviceCollection.AddDbContext<JudoDesContext>(optionsAction =>
        {
            optionsAction.UseSqlServer(configuration.GetConnectionString("Default"));
            optionsAction.EnableDetailedErrors();
            optionsAction.EnableSensitiveDataLogging();
        });
    }
}