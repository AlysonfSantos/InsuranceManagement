using InsuranceProposalManagement.Domain.Interfaces;
using InsuranceProposalManagement.Infrastructure.DataBase;
using InsuranceProposalManagement.Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace InsuranceProposalManagement.Infrastructure;

[ExcludeFromCodeCoverage]
public static class ConfigureServices
{
    public static IServiceCollection ConfigureInfrastructureServices(this IServiceCollection services, IConfiguration configuration, IHostEnvironment environment)
    {
        services.AddHealthChecks()
            .AddDbContextCheck<InsuranceProposalContext>(); ;
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddScoped<IIsuranceContracRepository, IsuranceProposalRepository>();

        var connectionString = configuration.GetConnectionString(InsuranceProposalContext.CONNECTION_STRING_SECTION)!;

        services.AddDbContext<InsuranceProposalContext>((sp, options) =>
        {
            options.UseSqlServer(connectionString);
        });
      
        return services;
    }
}