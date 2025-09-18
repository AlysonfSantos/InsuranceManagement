using InsuranceProposalManagement.Domain.Entities;
using InsuranceProposalManagement.Domain.Util;

namespace InsuranceProposalManagement.Domain.Interfaces;

public interface IIsuranceContracRepository
{
    Task<InsuranceProposal> CreateProposal(InsuranceProposal insuranceProposal);
    Task<InsuranceProposal?> GetProposalById(int id);
    Task<IEnumerable<InsuranceProposal>> GetListProposal();
    Task<InsuranceProposal> UpdateProposal(int id, string cpf, StatusType status);
    Task<InsuranceProposal?> GetProposalByIdAndCPF(int id, string cpf);
}
