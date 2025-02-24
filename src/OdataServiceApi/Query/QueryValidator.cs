using FluentValidation.Results;
using Microsoft.AspNetCore.OData.Query;

namespace OdataServiceApi.Query;

public class QueryValidator : IQueryValidator
{
    public ValidationResult Validate<T>(ODataQueryOptions<T> options)
    {
        throw new NotImplementedException();
    }
}
