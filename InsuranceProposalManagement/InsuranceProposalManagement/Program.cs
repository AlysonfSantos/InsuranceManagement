using InsuranceProposalManagement.Application;
using InsuranceProposalManagement.Infrastructure;
using Shared.Library.Bus;
using Shared.Library.Bus.Configuration;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

BusConfiguration busConfiguration = new();
builder.Configuration.GetSection(nameof(BusConfiguration))
    .Bind(busConfiguration);

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
});
builder.Services.ConfigureInfrastructureServices(builder.Configuration, builder.Environment);
builder.Services.ConfigureApplicationServices();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddBusConfiguration(
    busConfiguration,
    massTransitConfig =>
    {
        // Add consumers here
        //massTransitConfig.AddConsumer<MyConsumer, MyConsumerDefinition>();
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
