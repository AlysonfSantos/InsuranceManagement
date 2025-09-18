using AutoMapper;
using InsuranceProposalManagement.Application.Command;
using InsuranceProposalManagement.Domain.Entities;
using InsuranceProposalManagement.Domain.Interfaces;
using MediatR;

namespace InsuranceProposalManagement.Application.Handler;

public class CreateProposalHandler(IIsuranceContracRepository repository, IMapper map) : IRequestHandler<CreateProposalCommand, InsuraceProposalResult>
{
    public async Task<InsuraceProposalResult> Handle(CreateProposalCommand request, CancellationToken cancellationToken)
    {

        var proposal = map.Map<InsuranceProposal>(request);
        var result = await repository.CreateProposal(proposal);

        if (result is null)
            return InsuraceProposalResult.InsuraceProposalNouFound();

        return InsuraceProposalResult.InsuraceProposalCreated(result);
    }
}
