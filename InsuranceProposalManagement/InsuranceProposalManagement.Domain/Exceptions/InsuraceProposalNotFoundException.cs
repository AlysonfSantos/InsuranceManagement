namespace InsuranceProposalManagement.Domain.Exceptions;

public class InsuraceProposalNotFoundException(int id) : Exception
{
    public int InsuranceProposalId { get; private set; } = id;
}
