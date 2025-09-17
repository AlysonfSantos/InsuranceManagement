using AutoMapper;
using InsuranceContractManagement.Domain.Entities;
using InsuranceContractManagement.Domain.Interfaces;
using InsuranceContractManagement.Infrastructure.DataBase;

namespace InsuranceContractManagement.Infrastructure.Repositories;

public class InsuranceContractRepository(InsuranceContractContext context, IMapper map) : IInsuranceContractRepository
{
    public async Task<InsuranceContract?> GetContractById(int id)
    {
        var model = await context.InsuranceContract.FindAsync(id);
        if (model == null) return null;
        return map.Map<InsuranceContract>(model);
    }
}
