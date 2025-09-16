using InsuranceProposalManagement.Domain.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceProposalManagement.Domain.Entities;

public class ChangeInsuranceProposal
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
