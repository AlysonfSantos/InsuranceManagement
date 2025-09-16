using InsuranceProposalManagement.Application.Queries;
using MediatR;

namespace InsuranceProposalManagement.Application.Command;

public class GetListProposalCommand : IRequest<IEnumerable<GetInsuraceProposalByIdQuery>>
{
    public int ID { get; set; }
}
