using AutoMapper;
using InsuranceContractManagement.Application.Command;
using InsuranceContractManagement.Application.Queries;
using InsuranceContractManagement.Domain.Interfaces;
using MediatR;

namespace InsuranceContractManagement.Application.Handler;

public class GetInsuranceContractHandler(IInsuranceContractRepository repository, IMapper map) : IRequestHandler<GetInsuranceContractQuery, InsuranceContractResult>
{
    public async Task<InsuranceContractResult> Handle(GetInsuranceContractQuery request, CancellationToken cancellationToken)
    {
        var result = await repository.GetContractById(request.Id);
   
        if (result == null || result == null)
            return InsuranceContractResult.InsuraceContractNouFound();

        var contract = map.Map<Queries.GetInsuranceContractQuery>(result);

        return  InsuranceContractResult.InsuraceContractCreated(contract);
    }
}
