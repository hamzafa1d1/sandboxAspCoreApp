using challengeApp.Services;

namespace challengeApp.Extensions;

public static class ServiceExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        // define services for DI 
        services.AddScoped<ICodingChallenge, CodingChallenge>();
        return services;
    }
}