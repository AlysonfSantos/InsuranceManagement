using AutoMapper;
using InsuranceContractManagement.Application.Command;
using InsuranceContractManagement.Application.Queries;
using InsuranceContractManagement.Domain.Interfaces;
using MediatR;

namespace InsuranceContractManagement.Application.Handler;

public class GetInsuranceContractHandler(IInsuranceContractRepository repository, IMapper map) : IRequestHandler<GetInsuranceContractCommand, InsuranceContractResult>
{
    public async Task<InsuranceContractResult> Handle(GetInsuranceContractCommand request, CancellationToken cancellationToken)
    {
        var result = await repository.GetContractById(request.Id);
   
        if (result == null || result == null)
            return InsuranceContractResult.InsuraceContractNouFound();

        var contract = map.Map<GetInsuranceContractQuery>(result);

        return  InsuranceContractResult.InsuraceContractCreated(contract);
    }
}
