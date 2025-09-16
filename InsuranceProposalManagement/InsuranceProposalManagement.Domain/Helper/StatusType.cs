using System.ComponentModel.DataAnnotations;

namespace InsuranceProposalManagement.Domain.Util;

public enum StatusType
{
    [Display(Name = "Em Análise")]
    EmAnalise,

    [Display(Name = "Aprovada")]
    Aprovada,

    [Display(Name = "Rejeitada")]
    Rejeitada
}
