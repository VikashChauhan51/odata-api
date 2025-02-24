namespace OdataServiceApi.Resources.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public sealed class RelationshipAttribute : ResourcePropertyAttribute
{
    public override AttributeType Type => AttributeType.Relationship;
}
