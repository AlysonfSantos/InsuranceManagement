using InsuranceContractManagement.Application.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceContractManagement.Application.Command;

public class InsuranceContractResult
{
    public GetInsuranceContractQuery? Data { get; set; }
    public GetContractResult ResultGetContract { get; set; }

    public enum GetContractResult
    {
        ContractFound = 1,
        ContractNotFound = 2
    }

    public static InsuranceContractResult InsuraceContractCreated(GetInsuranceContractQuery data)
        => new(data, GetContractResult.ContractFound);

    public static InsuranceContractResult InsuraceContractNouFound()
        => new(null, GetContractResult.ContractNotFound);

    private InsuranceContractResult(GetInsuranceContractQuery? data, GetContractResult result)
    {
        Data = data;
        ResultGetContract = result;
    }

}
