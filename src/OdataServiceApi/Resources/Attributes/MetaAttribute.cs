namespace OdataServiceApi.Resources.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public sealed class MetaAttribute : ResourcePropertyAttribute
{
    public override AttributeType Type => AttributeType.Meta;
}
