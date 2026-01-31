namespace Capi.API;

public static class DependencyInjection
{
    /// <summary>
    /// Метод расширения для регистрации сервисов.
    /// </summary>
    /// <param name="services"></param>
    public static IServiceCollection AddApiServices(this IServiceCollection services, IConfiguration configuration)
    {
        // Swagger.
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        return services;
    }

    /// <summary>
    /// Метод расширения для конфигурации приложения.
    /// </summary>
    /// <param name="app"></param>
    /// <returns></returns>
    public static WebApplication UseApiServices(this WebApplication app)
    {
        var isDevEnvironment = app.Environment.IsDevelopment();
        if (isDevEnvironment)
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.MapGet("/", () => "Hello World!");

        return app;
    }
}