var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;

services.AddApiServices(builder.Configuration);
services.AddApplicationServices(builder.Configuration);
services.AddInfrastructureServices(builder.Configuration);

var app = builder.Build();

app.UseApiServices();

app.Run();