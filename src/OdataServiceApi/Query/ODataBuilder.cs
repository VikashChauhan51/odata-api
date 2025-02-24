using Microsoft.AspNetCore.OData.Query;
using Microsoft.OData.ModelBuilder;
using Microsoft.OData.UriParser;
using OdataServiceApi.Resources;

namespace OdataServiceApi.Query;

public static class ODataBuilder
{

    public static ODataQueryOptions<T> BuildODataOptions<T>(this HttpRequest request)
        where T : class, IResource
    {
        var modelBuilder = new ODataConventionModelBuilder();
        modelBuilder.AddEntityType(typeof(T));
        var edmModel = modelBuilder.GetEdmModel();
        var oDataQueryContext = new ODataQueryContext(edmModel, typeof(T), new ODataPath());
        return new ODataQueryOptions<T>(oDataQueryContext, request);
    }
}
