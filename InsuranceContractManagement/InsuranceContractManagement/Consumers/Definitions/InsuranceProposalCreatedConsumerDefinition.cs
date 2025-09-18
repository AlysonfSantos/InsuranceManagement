using MassTransit;

namespace InsuranceContractManagement.Consumers.Definitions;

public class InsuranceProposalCreatedConsumerDefinition : ConsumerDefinition<InsuranceProposalCreatedConsumer>
{
    public InsuranceProposalCreatedConsumerDefinition(IHostEnvironment hostEnvironment)
    {
        EndpointName = $"{hostEnvironment.EnvironmentName}_{hostEnvironment.ApplicationName}_{nameof(InsuranceProposalCreatedConsumer)}";
    }
}