using MediatR;

namespace InsuranceContractManagement.Application.Command;

public class GetInsuranceContractCommand : IRequest<InsuranceContractResult>
{
    public int Id { get; set; }
}
