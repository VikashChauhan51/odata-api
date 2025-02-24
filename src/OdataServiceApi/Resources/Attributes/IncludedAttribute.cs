namespace OdataServiceApi.Resources.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public sealed class IncludedAttribute : ResourcePropertyAttribute
{
    public override AttributeType Type => AttributeType.Included;
}

