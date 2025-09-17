using InsuranceContractManagement.Application.Command;
using MediatR;

namespace InsuranceContractManagement.Application.Handler;

public class GetInsuranceContractHandler : IRequestHandler<GetInsuranceContractCommand, InsuraceContractResult>
{
    public Task<InsuraceContractResult> Handle(GetInsuranceContractCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
