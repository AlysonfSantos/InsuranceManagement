using InsuranceProposalManagement.Domain.Entities;

namespace InsuranceProposalManagement.Domain.Interfaces;

public interface IIsuranceContracRepository
{

   Task  CreateProposal(InsuranceProposal insuranceProposal);

   Task<InsuranceProposal?> GetProposalById(int id);

}
