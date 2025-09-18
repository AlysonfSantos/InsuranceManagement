using InsuranceContractManagement.Application;
using InsuranceContractManagement.Consumers;
using InsuranceContractManagement.Consumers.Definitions;
using InsuranceContractManagement.Infrastructure;
using Shared.Library.Bus;
using Shared.Library.Bus.Configuration;
using System.Text.Json.Serialization;
using MassTransit;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers().AddJsonOptions(options =>
        {
            options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
        });

        BusConfiguration busConfiguration = new();
        builder.Configuration.GetSection(nameof(BusConfiguration))
            .Bind(busConfiguration);


        builder.Services.ConfigureInfrastructureServices(builder.Configuration, builder.Environment);
        builder.Services.ConfigureApplicationServices();
        ;
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();


        builder.Services.AddBusConfiguration(
            busConfiguration,
            massTransitConfig =>
            {
                // Add consumers here
                massTransitConfig.AddConsumer<InsuranceProposalCreatedConsumer, InsuranceProposalCreatedConsumerDefinition>();
            });

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}