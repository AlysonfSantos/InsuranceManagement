using InsuranceProposalManagement.Domain.Util;

namespace InsuranceProposalManagement.Domain.Entities;

public class InsuranceProposal
{
    public int Id { get; set; }
    public required decimal ProposalValue { get; set; }
    public required string ClientName { get; set; }
    public required string CPF { get; set; }
    public required DateTime DataOfBirth { get; set; }
    public required decimal CoverageValue { get; set; }
    public int DeadlineMonths { get; set; } 
    public StatusType Status { get; set; }
}
