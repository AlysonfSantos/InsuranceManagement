using AutoMapper;
using InsuranceProposalManagement.Domain.Entities;
using InsuranceProposalManagement.Domain.Interfaces;
using InsuranceProposalManagement.Infrastructure.DataBase;
using InsuranceProposalManagement.Infrastructure.Models;
using Microsoft.Identity.Client;

namespace InsuranceProposalManagement.Infrastructure.Repositories;

public class IsuranceProposalRepository(InsuranceProposalContext context, IMapper map) : IIsuranceContracRepository
{

    public async Task CreateProposal(InsuranceProposal insuranceProposal)
    {
        var model = map.Map<InsuranceProposalModel>(insuranceProposal);
        await context.InsuranceProposals.AddAsync(model);
        await context.SaveChangesAsync();
    }

    public async Task<InsuranceProposal?> GetProposalById(int id)
    {
        var model = await context.InsuranceProposals.FindAsync(id);
        if (model == null) return null;
        return map.Map<InsuranceProposal>(model);
    }
}
