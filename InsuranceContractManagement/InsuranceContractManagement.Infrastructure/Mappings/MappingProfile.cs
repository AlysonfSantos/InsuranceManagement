using AutoMapper;
using InsuranceContractManagement.Domain.Entities;
using InsuranceContractManagement.Infrastructure.Models;

namespace InsuranceContractManagement.Infrastructure.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        DomainToInfrastructureMappings();
        InfrastructureToDomainMappings();
    }

    private void DomainToInfrastructureMappings()
    {
        CreateMap<InsuranceContract, InsuranceContractModel>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());

    }

    private void InfrastructureToDomainMappings()
    {
        CreateMap<InsuranceContractModel, InsuranceContract>();
            
    }
}