using InsuranceProposalManagement.Domain.Entities;
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

    public InsuranceProposal InsuraceProposal { get; set; }
    
    public bool IsUpdateStatus { get; set; }
    public ResultType ResultTypeStatus { get; set; }


    public static InsuraceProposalResult InsuraceProposalCreated(InsuranceProposal insuraceProposal)    
        => new(insuraceProposal, ResultType.InsuranceProposalCreated, false);

    public static InsuraceProposalResult InsuraceProposalChanged(InsuranceProposal insuraceProposal, bool isUpdated)
        => new(insuraceProposal, ResultType.InsuranceProposalStatusChanged, isUpdated);

    public static InsuraceProposalResult InsuraceProposalNouFound()
        => new(null ,ResultType.InsuranceProposalNotFound, false);

    private InsuraceProposalResult(InsuranceProposal insuraceProposal, ResultType result, bool isUpdated)
    { 
        InsuraceProposal = insuraceProposal;
        ResultTypeStatus = result;
        IsUpdateStatus = isUpdated;
    }
}
