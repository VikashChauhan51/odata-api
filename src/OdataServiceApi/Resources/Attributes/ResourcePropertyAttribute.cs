namespace OdataServiceApi.Resources.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public abstract class ResourcePropertyAttribute : Attribute
{

    public abstract AttributeType Type { get; }
}
