namespace InsuranceContractManagement.Infrastructure.Models;

public class InsuranceContractModel
{
    public int Id { get; set; }
    public string number { get; set; }
    public DateTime StartDate { get; set; }
    public bool Signature { get; set; }
    public int InsureProposalId { get; set; }
    public string CPF { get; set; }
    public string ClientName { get; set; }
}
