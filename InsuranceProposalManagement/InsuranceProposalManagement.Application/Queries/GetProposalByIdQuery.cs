using InsuranceProposalManagement.Domain.Util;
using MediatR;

namespace InsuranceProposalManagement.Application.Queries;

public class GetProposalByIdQuery : IRequest<GetInsuraceProposalByIdQuery>
{
    public int ID { get; set; } 
}
