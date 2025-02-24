using System.Reflection;

namespace OdataServiceApi.Query;

public static class TypeExtensions
{
    public static IEnumerable<PropertyInfo> GetPropertiesWithAttributeFlattened<TAttribute>(this Type type)
        where TAttribute : Attribute
    {
        if (!type.IsClass || type.IsPrimitive || type.IsInterface || type == typeof(string))
        {
            return null;
        }

        var properties = type.GetProperties();
        var allowed = new List<PropertyInfo>();
        foreach (var prop in properties)
        {
            if (prop.GetCustomAttribute<TAttribute>() != null)
            {
                allowed.Add(prop);
            }
            else if (prop.PropertyType.IsClass && prop.PropertyType != typeof(string))
            {
                allowed.AddRange(GetPropertiesWithAttributeFlattened<TAttribute>(prop.PropertyType));
            }

        }
        return allowed.Distinct();
    }

    public static Type? GetCollectionType(this Type type)
    {
        if (type.IsArray)
        {
            return type.GetElementType();
        }
        if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(IEnumerable<>))
        {
            return type.GetGenericArguments()[0];
        }
        return null;
    }
}
