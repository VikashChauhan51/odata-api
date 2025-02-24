using FluentValidation.Results;
using Microsoft.AspNetCore.OData.Query;

namespace OdataServiceApi.Query;

public interface IQueryValidator
{
    public ValidationResult Validate<T>(ODataQueryOptions<T> options);
}

