using InsuranceContractManagement.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace InsuranceContractManagement.Infrastructure.DataBase;

public class InsuranceContractContext(DbContextOptions<InsuranceContractContext> options) : DbContext(options)
{
    public const string CONNECTION_STRING_SECTION = "DefaultConnection";

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    public virtual DbSet<InsuranceContractModel> InsuranceContract { get; set; } = null!;
}