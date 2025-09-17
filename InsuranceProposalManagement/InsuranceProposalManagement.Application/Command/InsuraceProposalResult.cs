using InsuranceProposalManagement.Domain.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace InsuranceProposalManagement.Application.Command;

public record InsuraceProposalResult
{
    public bool IsValue { get; set; }
    public ResultType ResultTypeStatus { get; set; }


    public static InsuraceProposalResult InsuraceProposalCreated(bool isValue)
        => new(true, ResultType.InsuranceProposalCreated);

    public static InsuraceProposalResult InsuraceProposalChanged(bool isValue)
        => new(true, ResultType.InsuranceProposalStatusChanged);

    public static InsuraceProposalResult InsuraceProposalNouFound(bool isValue)
        => new(false, ResultType.InsuranceProposalNotFound);

    private InsuraceProposalResult(bool isValue, ResultType result)
    {
        IsValue = isValue;
        ResultTypeStatus = result;
    }
}
