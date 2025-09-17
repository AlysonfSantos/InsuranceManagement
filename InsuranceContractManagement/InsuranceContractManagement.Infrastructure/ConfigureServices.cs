using InsuranceContractManagement.Domain.Interfaces;
using InsuranceContractManagement.Infrastructure.DataBase;
using InsuranceContractManagement.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
namespace InsuranceContractManagement.Infrastructure;

[ExcludeFromCodeCoverage]
public static class ConfigureServices
{
    public static IServiceCollection ConfigureInfrastructureServices(this IServiceCollection services, IConfiguration configuration, IHostEnvironment environment)
    {
        services.AddHealthChecks()
            .AddDbContextCheck<InsuranceContractContext>(); ;
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddScoped<IInsuranceContractRepository, InsuranceContractRepository>();

        var connectionString = configuration.GetConnectionString(InsuranceContractContext.CONNECTION_STRING_SECTION)!;

        services.AddDbContext<InsuranceContractContext>((sp, options) =>
        {
            options.UseSqlServer(connectionString);
        });

        return services;
    }
}