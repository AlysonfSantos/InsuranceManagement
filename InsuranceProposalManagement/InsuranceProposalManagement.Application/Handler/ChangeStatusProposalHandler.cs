using InsuranceProposalManagement.Application.Command;
using InsuranceProposalManagement.Domain.Interfaces;
using InsuranceProposalManagement.Domain.Util;
using InsuranceProposalManagement.MessageContract;
using MediatR;
using Shared.Library.Bus.Services;

namespace InsuranceProposalManagement.Application.Handler;

public class ChangeStatusProposalHandler(IIsuranceContracRepository repository, IMessagingService messagingService) : IRequestHandler<ChangeProposalCommand, InsuraceProposalResult>
{
    public async Task<InsuraceProposalResult> Handle(ChangeProposalCommand request, CancellationToken cancellationToken)
    {
        var result = await repository.UpdateProposal(request.ID, request.CPF, request.Status);

        if (result is null)
            return InsuraceProposalResult.InsuraceProposalNouFound();

        if(result.Status.Equals(StatusType.Aprovada))
            await messagingService.PublishMessageAsync(new InsuraceProposalAproved  
            {
                ID = result.Id,
                CPF = result.CPF,
                Status = result.Status.ToString(),
                ClientName = result.ClientName,
                DataOfBirth = result.DataOfBirth,
                CoverageValue = result.CoverageValue,
                DeadlineMonths = result.DeadlineMonths,
                ProposalValue = result.ProposalValue

            }, cancellationToken);

        return  InsuraceProposalResult.InsuraceProposalChanged(result, true);
    }
}

