namespace ArchSoft.ExtensionMethods;

public static class CollectionExtension
{
    public static bool IsNullOrEmpty<T>(this IEnumerable<T>? collection)
    {
        if (collection == null) return true;

        return !collection.Any();
    }
}