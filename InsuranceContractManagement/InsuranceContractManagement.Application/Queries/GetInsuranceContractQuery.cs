using InsuranceContractManagement.Application.Command;
using MediatR;

namespace InsuranceContractManagement.Application.Queries;

public class GetInsuranceContractQuery : IRequest<InsuranceContractResult>
{
    public int Id { get; set; }
}
