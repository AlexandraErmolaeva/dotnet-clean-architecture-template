namespace Capi.Infrastructure;

public static class DependencyInjection
{
    /// <summary>
    /// Метод расширения для регистрации сервисов.
    /// </summary>
    /// <param name="services"></param>
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        return services;
    }
}