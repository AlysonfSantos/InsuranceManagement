using MediatR;

namespace InsuranceProposalManagement.Application.Queries;

public class GetListProposalQuery : IRequest<IEnumerable<GetInsuraceProposalByIdQuery>>
{
    public int ID { get; set; }
}
