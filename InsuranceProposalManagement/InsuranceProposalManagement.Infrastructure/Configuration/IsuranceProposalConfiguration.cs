using InsuranceProposalManagement.Domain.Entities;
using InsuranceProposalManagement.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace InsuranceProposalManagement.Infrastructure.Configuration;

public class IsuranceProposalConfiguration : IEntityTypeConfiguration<InsuranceProposalModel>
{
    public void Configure(EntityTypeBuilder<InsuranceProposalModel> builder)
    {
        builder.ToTable("INSURANCE_PROPOSALS");

        builder.Property(p => p.ID).ValueGeneratedOnAdd();

        builder.Property(x => x.ProposalValue).HasColumnName("PROPOSAL_VALUE");

        builder.Property(x => x.CPF).HasColumnName("CPF")
           .HasMaxLength(11);

        builder.Property(x => x.ClientName).HasColumnName("CLIENT_NAME")
           .HasMaxLength(50);

        builder.Property(x => x.Status).HasColumnName("STATUS_PROPOSAL")
           .HasMaxLength(50);

        builder.Property(x => x.DataOfBirth).HasColumnName("DATA_OF_BIRTH");

        builder.Property(x => x.CoverageValue).HasColumnName("COVERAGE_VALUE");

        builder.Property(x => x.DeadlineMonths).HasColumnName("DEAD_LINE_MONGTHS");

    }
}