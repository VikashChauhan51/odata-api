using Microsoft.AspNetCore.OData.Query.Validator;
using Microsoft.OData.UriParser;
using OdataServiceApi.Query.Attributes;

namespace OdataServiceApi.Query;

public class QueryFilterPropertyValidator<T> : FilterQueryValidator
    where T : class
{
    private readonly string[] _allowedProperties = typeof(T).GetPropertiesWithAttributeFlattened<FilterableAttribute>().Select(x => x.Name).ToArray();


    protected override void ValidateSingleValuePropertyAccessNode(SingleValuePropertyAccessNode propertyAccessNode, FilterValidatorContext validatorContext)
    {

        if (_allowedProperties.Contains(propertyAccessNode.Property.Name))
        {
            base.ValidateSingleValuePropertyAccessNode(propertyAccessNode, validatorContext);
        }
    }
}
