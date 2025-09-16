using AutoMapper;
using InsuranceProposalManagement.Application.Command;
using InsuranceProposalManagement.Application.Queries;
using InsuranceProposalManagement.Domain.Interfaces;
using MediatR;

namespace InsuranceProposalManagement.Application.Handler;

public class GetProposalHandler(IIsuranceContracRepository repository, IMapper map) : IRequestHandler<GetProposalCommand, GetInsuraceProposalByIdQuery>
{
    public async Task<GetInsuraceProposalByIdQuery> Handle(GetProposalCommand request, CancellationToken cancellationToken)
    {
       
        var result = await repository.GetProposalById(request.ID);

        return map.Map<GetInsuraceProposalByIdQuery>(result);
    }
}
