using MediatR;

namespace InsuranceContractManagement.Application.Command;

public class GetInsuranceContractCommand : IRequest<InsuraceContractResult>
{
    public int Id { get; set; }
}
