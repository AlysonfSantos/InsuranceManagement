using AutoMapper;
using InsuranceProposalManagement.Domain.Entities;
using InsuranceProposalManagement.Domain.Interfaces;
using InsuranceProposalManagement.Domain.Util;
using InsuranceProposalManagement.Infrastructure.DataBase;
using InsuranceProposalManagement.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
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

    public async Task<InsuranceProposal?> GetProposalByIdAndCPF(int id, string cpf)
    {
        var model = await context.InsuranceProposals.Where(x => x.ID == id && x.CPF == cpf).FirstOrDefaultAsync();
        if (model == null) return null;
        return map.Map<InsuranceProposal>(model);
    }

    public async Task<IEnumerable<InsuranceProposal>> GetListProposal()
    {
        var model = await context.InsuranceProposals.ToListAsync();
        return map.Map<IEnumerable<InsuranceProposal>>(model);
    }

    public async Task<bool> UpdateProposal(int id, string cpf, StatusType status)
    {
        var model = await context.InsuranceProposals.FirstOrDefaultAsync(x => x.ID == id && x.CPF == cpf);

        if(model is null)
            return false;

        model.Status = StatusExtensions.GetDisplayName(status);
        context.InsuranceProposals.Update(model);
        context.SaveChanges();
        return true;
    }
}
