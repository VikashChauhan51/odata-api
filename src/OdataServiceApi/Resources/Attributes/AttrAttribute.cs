namespace OdataServiceApi.Resources.Attributes;


[AttributeUsage(AttributeTargets.Property)]
public sealed class AttrAttribute : ResourcePropertyAttribute
{
    public override AttributeType Type => AttributeType.Attribute;
}
