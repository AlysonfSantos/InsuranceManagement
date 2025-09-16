using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace InsuranceProposalManagement.Domain.Util;

public class Helper
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

    public static TEnum GetEnumValueFromDisplayNameSafe<TEnum>(string displayName, TEnum defaultValue) where TEnum : Enum
    {
        foreach (var field in typeof(TEnum).GetFields())
        {
            var attribute = field.GetCustomAttribute<DisplayAttribute>();
            if (attribute?.Name == displayName)
                return (TEnum)field.GetValue(null);
        }

        return defaultValue;
    }
}





