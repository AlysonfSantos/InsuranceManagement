using InsuranceProposalManagement.Domain.Entities;
using InsuranceProposalManagement.Domain.Util;

namespace InsuranceProposalManagement.Domain.Interfaces;

public interface IIsuranceContracRepository
{
    Task  CreateProposal(InsuranceProposal insuranceProposal);
    Task<InsuranceProposal?> GetProposalById(int id);
    Task<IEnumerable<InsuranceProposal>> GetListProposal();
    Task<bool> UpdateProposal(int id, string cpf, StatusType status);
    Task<InsuranceProposal?> GetProposalByIdAndCPF(int id, string cpf);
}
