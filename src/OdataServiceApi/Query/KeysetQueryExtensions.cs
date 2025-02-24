using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.OData.Query;

namespace OdataServiceApi.Query;

public static class KeysetQueryExtensions
{
    public static string? MakeNextLink(this ODataQueryOptions options, string? newSkipToken)
    {
        if (string.IsNullOrEmpty(newSkipToken))
        {
            return null;
        }

        if (options.Request.Query.TryGetValue("$skipToken", out var currentValue))
        {
            return options.Request.GetEncodedUrl().Replace("$skipToken=" + currentValue, "skipToken=" + newSkipToken, StringComparison.OrdinalIgnoreCase);
        }

        if (options.Request.Query.TryGetValue("skipToken", out var value))
        {
            return options.Request.GetEncodedUrl().Replace("skipToken=" + value, "skipToken=" + newSkipToken, StringComparison.OrdinalIgnoreCase);
        }

        return options.Request.GetEncodedUrl() + "&skipToken=" + newSkipToken;
    }
}
