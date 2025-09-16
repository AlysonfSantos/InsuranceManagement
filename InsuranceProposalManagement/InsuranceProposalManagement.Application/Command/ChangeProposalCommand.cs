using InsuranceProposalManagement.Domain.Util;
using MediatR;

namespace InsuranceProposalManagement.Application.Command;

public class ChangeProposalCommand : IRequest<InsuraceProposalResult>
{
    public required int ID { get; set; }
    public required string CPF { get; set; }
    public required StatusType Status { get; set; }
}
