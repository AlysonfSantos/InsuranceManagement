using InsuranceProposalManagement.Domain.Interfaces;
using InsuranceProposalManagement.Domain.Util;
using MediatR;

namespace InsuranceProposalManagement.Application.Command;



//VERIFICAR O TIPO DE RETORNO
public class CreateProposalCommand : IRequest<InsuraceProposalResult>
{
    public required decimal ProposalValue { get; set; }
    public required string ClientName { get; set; }
    public required string CPF { get; set; }
    public required DateTime DataOfBirth { get; set; }
    public required decimal CoverageValue { get; set; }
    public int DeadlineMonths { get; set; }
    public StatusType Status { get; set; }
}
