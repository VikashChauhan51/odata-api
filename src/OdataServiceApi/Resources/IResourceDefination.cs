using OdataServiceApi.Resources.Attributes;

namespace OdataServiceApi.Resources;

public interface IResourceDefination
{
    Type Type { get; }
    string Name { get; }
    IReadOnlyDictionary<string, ResourcePropertyInfo> Properties { get; }
}
