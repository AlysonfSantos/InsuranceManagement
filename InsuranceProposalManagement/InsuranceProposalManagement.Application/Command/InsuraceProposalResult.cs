using InsuranceProposalManagement.Domain.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceProposalManagement.Application.Command;

public record InsuraceProposalResult
{
    public ResultType ResultTypeStatus { get; set; }

    public InsuraceProposalResult(ResultType ResultType)
    {
        ResultTypeStatus = ResultType;
    }

    public static InsuraceProposalResult InsuraceProposalCreated()
        => new(ResultType.InsuranceProposalCreated);
}
