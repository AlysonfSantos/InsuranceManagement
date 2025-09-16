using AutoMapper;
using InsuranceProposalManagement.Domain.Entities;
using InsuranceProposalManagement.Domain.Util;
using InsuranceProposalManagement.Infrastructure.Models;

namespace InsuranceProposalManagement.Infrastructure.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        DomainToInfrastructureMappings();
        InfrastructureToDomainMappings();
    }

    private void DomainToInfrastructureMappings()
    {
        CreateMap<InsuranceProposal, InsuranceProposalModel>()
            .ForMember(dest => dest.Status,
               opt => opt.MapFrom(src => StatusExtensions.GetDisplayName(src.Status)))
            .ForMember(dest => dest.ID, opt => opt.Ignore());

        CreateMap<ChangeInsuranceProposal, InsuranceProposalModel>()
            .ForMember(dest => dest.Status,
               opt => opt.MapFrom(src => StatusExtensions.GetDisplayName(src.Status))); 
    }

    private void InfrastructureToDomainMappings()
    {
        CreateMap<InsuranceProposalModel, InsuranceProposal>()
            .ForMember(dest => dest.Status,
           opt => opt.MapFrom(src => StatusExtensions.GetEnumValueFromDisplayNameSafe<StatusType>(src.Status, StatusType.EmAnalise))); ; 
    }
}