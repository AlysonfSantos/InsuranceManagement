using AutoMapper;
using InsuranceProposalManagement.Application.Command;
using InsuranceProposalManagement.Application.Queries;
using InsuranceProposalManagement.Domain.Interfaces;
using MediatR;

namespace InsuranceProposalManagement.Application.Handler;

public class GetProposalHandler(IIsuranceContracRepository repository, IMapper map) : IRequestHandler<GetProposalByIdCommand, GetInsuraceProposalByIdQuery>
{
    public async Task<GetInsuraceProposalByIdQuery> Handle(GetProposalByIdCommand request, CancellationToken cancellationToken)
    {
       
        var result = await repository.GetProposalById(request.ID);

        return map.Map<GetInsuraceProposalByIdQuery>(result);
    }
}
