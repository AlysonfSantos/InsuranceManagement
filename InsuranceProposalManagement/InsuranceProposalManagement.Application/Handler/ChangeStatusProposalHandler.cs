using AutoMapper;
using InsuranceProposalManagement.Application.Command;
using InsuranceProposalManagement.Domain.Entities;
using InsuranceProposalManagement.Domain.Interfaces;
using InsuranceProposalManagement.Domain.Util;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceProposalManagement.Application.Handler;

public class ChangeStatusProposalHandler(IIsuranceContracRepository repository, IMapper map) : IRequestHandler<ChangeProposalCommand, InsuraceProposalResult>
{
    public async Task<InsuraceProposalResult> Handle(ChangeProposalCommand request, CancellationToken cancellationToken)
    {
        var getProposal = await repository.GetProposalByIdAndCPF(request.ID, request.CPF);

        if (getProposal != null)
               getProposal.Status = request.Status;

        await repository.UpdateProposal(request.ID, request.CPF, request.Status);

        return InsuraceProposalResult.InsuraceProposalCreated();
    }
}