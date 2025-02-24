using System.Web;

namespace OdataServiceApi.Query;

public static class QueryStringExtensions
{
    public static Dictionary<string, string?> ToDictionary(this QueryString queryString)
    {
        var queryCollection = HttpUtility.ParseQueryString(queryString.Value ?? string.Empty);

        return queryCollection.AllKeys.Where(key => !string.IsNullOrEmpty(key)).ToDictionary(key => key!, key => queryCollection[key]);
    }
}
