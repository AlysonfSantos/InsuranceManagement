using InsuranceProposalManagement.Domain.Util;

namespace InsuranceProposalManagement.Application.Queries;

public class GetInsuraceProposalByIdQuery
{
    public int ID { get; set; }
    public required decimal ProposalValue { get; set; }
    public required string ClientName { get; set; }
    public required string CPF { get; set; }
    public required DateTime DataOfBirth { get; set; }
    public required decimal CoverageValue { get; set; }
    public int DeadlineMonths { get; set; }
    public StatusType Status { get; set; }
}
