using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace InsuranceProposalManagement.Domain.Util;

public class Util
{
}


public static class StatusExtensions
{
    public static string GetDisplayName(Enum value)
    {
        var field = value.GetType().GetField(value.ToString());
        var attr = field?.GetCustomAttribute<DisplayAttribute>();
        return attr?.Name ?? value.ToString();
    }
}



