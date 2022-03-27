using api.Data.Repositories;
using api.Data.Repositories.Interfaces;
using api.Services.Queries;
using Mapster;
using MapsterMapper;
using MediatR;

namespace api.Data.Extensions;

public static class DependenciesContainer
{
    public static IServiceCollection RegisterDependencies(this IServiceCollection services)
    {
        var config = new TypeAdapterConfig();
        services.AddSingleton(config);
        services.AddTransient<IMapper, ServiceMapper>();
        services.AddTransient(typeof(IRepository<>), typeof(GenericRepository<>));
        services.AddScoped<IOnePieceRepository, OnePieceRepository>();
        services.AddMediatR(typeof(GetAllPiratesQuery).Assembly);
        return services;
    }
}