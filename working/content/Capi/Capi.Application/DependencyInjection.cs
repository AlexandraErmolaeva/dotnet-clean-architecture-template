namespace Capi.Application;

public static class DependencyInjection
{
    /// <summary>
    /// Метод расширения для регистрации сервисов.
    /// </summary>
    /// <param name="services"></param>
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        return services;
    }
}