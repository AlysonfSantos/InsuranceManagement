using Microsoft.Extensions.DependencyInjection;
using Shared.Library.MediatR;
using System.Reflection;

namespace InsuranceProposalManagement.Application;

public static class ConfigureServices
{
    public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services)
    {
        services.RegisterMediatR(Assembly.GetExecutingAssembly());

        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        return services;
    }
}