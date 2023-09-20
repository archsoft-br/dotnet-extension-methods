using System.ComponentModel;

namespace ArchSoft.ExtensionMethods;

public static class EnumExtension
{
    public static string? GetDescription(this Enum value)
    {
        var type = value.GetType();

        var name = Enum.GetName(type, value);
        if (name == null) return name;

        var field = type.GetField(name);
        if (field == null) return name;

        var customAttribute = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));

        if (customAttribute is DescriptionAttribute attribute) return attribute.Description;

        return name;
    }
}