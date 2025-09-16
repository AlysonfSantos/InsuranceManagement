using InsuranceProposalManagement.Domain.Util;

namespace InsuranceProposalManagement.Infrastructure.Models;

public class InsuranceProposalModel
{
    public int? ID { get; set; }
    public required decimal ProposalValue { get; set; }
    public required string ClientName { get; set; }
    public required string CPF { get; set; }
    public required DateTime DataOfBirth { get; set; }
    public required decimal CoverageValue { get; set; }
    public int DeadlineMonths { get; set; }
    public string? Status { get; set; } 
}
