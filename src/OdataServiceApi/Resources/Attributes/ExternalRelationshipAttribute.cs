namespace OdataServiceApi.Resources.Attributes;


[AttributeUsage(AttributeTargets.Property)]
public sealed class ExternalRelationshipAttribute : ResourcePropertyAttribute
{
    public override AttributeType Type => AttributeType.ExternalRelationship;
}

