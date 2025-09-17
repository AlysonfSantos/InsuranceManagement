using InsuranceContractManagement.Domain.Entities;

namespace InsuranceContractManagement.Domain.Interfaces;

public interface IInsuranceContractRepository
{
    Task<InsuranceContract?> GetContractById(int id);
}
