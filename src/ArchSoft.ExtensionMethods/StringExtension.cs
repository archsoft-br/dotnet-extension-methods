using System.Globalization;

namespace ArchSoft.ExtensionMethods;

public static class StringExtension
{
    public static string ToCapitalize(this string value)
    {
        return string.IsNullOrWhiteSpace(value) ? string.Empty : CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
    }

    public static T? ToEnum<T>(this string value) where T : struct, Enum
    {
        if (Enum.TryParse<T>(value, out var result)) return result;

        return null;
    }
}