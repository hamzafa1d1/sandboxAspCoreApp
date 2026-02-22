using challengeApp.DbConnectionSetup;
using challengeApp.Services;
using Microsoft.EntityFrameworkCore;

namespace challengeApp.Extensions;

public static class ServiceExtensions
{
    private const string DefaultConnectionString = "DefaultConnection";
    public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration  configuration)
    {
        // define services for DI 
        services.AddScoped<ICodingChallenge, CodingChallenge>();

        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString(DefaultConnectionString));
        });
        
        return services;
    }
}