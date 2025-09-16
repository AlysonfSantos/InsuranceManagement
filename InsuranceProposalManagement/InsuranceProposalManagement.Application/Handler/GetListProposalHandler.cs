using AutoMapper;
using InsuranceProposalManagement.Application.Command;
using InsuranceProposalManagement.Application.Queries;
using InsuranceProposalManagement.Domain.Interfaces;
using MediatR;

namespace InsuranceProposalManagement.Application.Handler;

public class GetListProposalHandler(IIsuranceContracRepository repository, IMapper map) : IRequestHandler<GetListProposalCommand, IEnumerable<GetInsuraceProposalByIdQuery>>
{
    public async Task<IEnumerable<GetInsuraceProposalByIdQuery>> Handle(GetListProposalCommand request, CancellationToken cancellationToken)
    {

        var result = await repository.GetListProposal();

        return map.Map<IEnumerable<GetInsuraceProposalByIdQuery>>(result);
    }
}