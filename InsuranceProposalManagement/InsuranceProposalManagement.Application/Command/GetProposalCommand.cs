using InsuranceProposalManagement.Application.Queries;
using InsuranceProposalManagement.Domain.Util;
using MediatR;

namespace InsuranceProposalManagement.Application.Command;

public class GetProposalCommand : IRequest<GetInsuraceProposalByIdQuery>
{
    public int ID { get; set; } 
}
