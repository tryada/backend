using Backend.Filters;
using Backend.Helpers;
using Backend.Repositories;
using Backend.Services;
using Microsoft.EntityFrameworkCore;

public static class WebApplicationBuilderExtensions
{
    public static WebApplicationBuilder Setup(this WebApplicationBuilder builder)
    {
        string connectionString = ConfigHelper.GetValue(builder.Configuration, "Configuration:connectionString");

        builder.Services.SetupServices(connectionString);

        return builder;
    }

    private static IServiceCollection SetupServices(this IServiceCollection servicesCollection, string connectionString)
    {
        servicesCollection.AddControllers(
            options => options.Filters.Add(typeof(ExceptionFilter))
        );

        servicesCollection.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        servicesCollection.AddDbContext<RepositoryContext>(
            options => options.UseSqlServer(connectionString)
        );

        servicesCollection.AddTransient<IRepositoryContext, RepositoryContext>();
        servicesCollection.AddTransient<IBikeService, BikeService>();
        servicesCollection.AddTransient<IBikeRepository, BikeRepository>();

        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        servicesCollection.AddEndpointsApiExplorer();
        servicesCollection.AddSwaggerGen();

        return servicesCollection;
    }
}