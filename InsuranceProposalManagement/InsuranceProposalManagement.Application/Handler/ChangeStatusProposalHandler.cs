using AutoMapper;
using InsuranceProposalManagement.Application.Command;
using InsuranceProposalManagement.Domain.Entities;
using InsuranceProposalManagement.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceProposalManagement.Application.Handler;

internal class ChangeStatusProposalHandler(IIsuranceContracRepository repository, IMapper map) : IRequestHandler<CreateProposalCommand, InsuraceProposalResult>
{
    public async Task<InsuraceProposalResult> Handle(CreateProposalCommand request, CancellationToken cancellationToken)
    {

        var proposal = map.Map<InsuranceProposal>(request);
        await repository.CreateProposal(proposal);

        return InsuraceProposalResult.InsuraceProposalCreated();
    }
}