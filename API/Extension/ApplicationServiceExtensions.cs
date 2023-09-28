

using Core.Interfaces;
using Infrastructure.UnitOfWork;

namespace API.Extension;

public static class ApplicationServiceExtensions
{
    public static void ConfigureCors(this IServiceCollection services) =>
    services.AddCors(options =>
    {
        options.AddPolicy("CorsPolicy", builder =>
            builder.AllowAnyOrigin()    //WithOrigins("https://domain.com")
                .AllowAnyMethod()       //WithMethods("GET","POST)
                .AllowAnyHeader());     //WithHeaders("accept","content-type")
    });
    public static void AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<UnitOfWork>();
    }
}
