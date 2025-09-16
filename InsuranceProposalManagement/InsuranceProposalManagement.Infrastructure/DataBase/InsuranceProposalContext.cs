using InsuranceProposalManagement.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace InsuranceProposalManagement.Infrastructure.DataBase;

public class InsuranceProposalContext(DbContextOptions<InsuranceProposalContext> options) : DbContext(options)
{
    public const string CONNECTION_STRING_SECTION = "DefaultConnection";

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    public virtual DbSet<InsuranceProposalModel> InsuranceProposals { get; set; } = null!;
}