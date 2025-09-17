using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceContractManagement.Application.Command;

public class InsuraceContractResult
{

    public bool IsValue { get; set; }
    public GetContractResult ResultGetContract { get; set; }

    public enum GetContractResult
    {
        ContractFound = 1,
        ContractNotFound = 2
    }

    public static InsuraceContractResult InsuraceProposalCreated(bool isValue)
        => new(true, GetContractResult.ContractFound);
    public static InsuraceContractResult InsuraceProposalNouFound(bool isValue)
        => new(false, GetContractResult.ContractNotFound);

    private InsuraceContractResult(bool isValue, GetContractResult result)
    {
        IsValue = isValue;
        ResultGetContract = result;
    }


}
