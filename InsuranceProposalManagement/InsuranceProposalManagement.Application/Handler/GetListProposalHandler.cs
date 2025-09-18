using AutoMapper;
using InsuranceProposalManagement.Application.Queries;
using InsuranceProposalManagement.Domain.Interfaces;
using MediatR;

namespace InsuranceProposalManagement.Application.Handler;

public class GetListProposalHandler(IIsuranceContracRepository repository, IMapper map) : IRequestHandler<GetListProposalQuery, IEnumerable<GetInsuraceProposalByIdQuery>>
{
    public async Task<IEnumerable<GetInsuraceProposalByIdQuery>> Handle(GetListProposalQuery request, CancellationToken cancellationToken)
    {

        var result = await repository.GetListProposal();

        return map.Map<IEnumerable<GetInsuraceProposalByIdQuery>>(result);
    }
}