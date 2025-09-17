using InsuranceContractManagement.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InsuranceContractManagement.Infrastructure.Configuration;

public class InsuranceContractConfiguration : IEntityTypeConfiguration<InsuranceContractModel>
{
    public void Configure(EntityTypeBuilder<InsuranceContractModel> builder)
    {
        builder.ToTable("INSURANCE_CONTRACTS");

        builder.HasKey(p => p.Id);

        builder.Property(x => x.InsureProposalId).HasColumnName("INSERANCE_PROPOSAL_ID");

        builder.Property(x => x.CPF).HasColumnName("CPF")
           .HasMaxLength(11);

        builder.Property(x => x.ClientName).HasColumnName("CLIENT_NAME")
           .HasMaxLength(50);

        builder.Property(x => x.number).HasColumnName("CONTRACT_NUMBER")
           .HasMaxLength(50);

        builder.Property(x => x.StartDate).HasColumnName("START_CONTRACT_DATE");

        builder.Property(x => x.Signature).HasColumnName("SIGNATURE_CONTRACT");

    }
}