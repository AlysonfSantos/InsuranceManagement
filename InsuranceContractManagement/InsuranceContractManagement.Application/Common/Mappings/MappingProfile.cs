using AutoMapper;
using InsuranceContractManagement.Application.Command;
using InsuranceContractManagement.Application.Queries;
using InsuranceContractManagement.Domain.Entities;

namespace InsuranceContractManagement.Application.Common.Mappings;

public class MappingProfile : Profile
{

    public MappingProfile()
    {
        ApplicationToDomainMappings();
        DomainToApplicationMappings();
    }

    private void ApplicationToDomainMappings()
    {
        CreateMap<GetInsuranceContractQuery, InsuranceContract>();
    }

    private void DomainToApplicationMappings()
    {
        CreateMap<InsuranceContract, GetInsuranceContractQuery>();
    }
}
