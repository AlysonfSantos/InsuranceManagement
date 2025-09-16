using AutoMapper;
using InsuranceProposalManagement.Application.Command;
using InsuranceProposalManagement.Application.Queries;
using InsuranceProposalManagement.Domain.Entities;

namespace InsuranceProposalManagement.Application.Common.Mappings;

public class MappingProfile : Profile
{

    public MappingProfile()
    {
        ApplicationToDomainMappings();
        DomainToApplicationMappings();
    }

    private void ApplicationToDomainMappings()
    {
        CreateMap<CreateProposalCommand, InsuranceProposal>();
    }

    private void DomainToApplicationMappings()
    {
        CreateMap<InsuranceProposal, GetInsuraceProposalByIdQuery>();
        CreateMap<GetInsuraceProposalByIdQuery, InsuranceProposal>();
    }
}
