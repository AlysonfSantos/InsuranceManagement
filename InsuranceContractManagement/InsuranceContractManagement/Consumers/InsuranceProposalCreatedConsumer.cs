using InsuranceProposalManagement.MessageContract;
using MassTransit;

namespace InsuranceContractManagement.Consumers;


public class InsuranceProposalCreatedConsumer(ILogger<InsuranceProposalCreatedConsumer> logger)
    : IConsumer<InsuraceProposalAproved>
{
    private readonly ILogger<InsuranceProposalCreatedConsumer> _logger = logger;

    public async Task Consume(ConsumeContext<InsuraceProposalAproved> context)
    {
        var message = context.Message;
        _logger.LogInformation("Consuming message: {@Message}", message);
    }
}