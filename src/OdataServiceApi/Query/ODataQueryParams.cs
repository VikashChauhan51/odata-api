using Microsoft.AspNetCore.Mvc;

namespace OdataServiceApi.Query;

public class ODataQueryParams
{
    [FromQuery(Name ="filter")]
    public string? Filter { get; set; }

    [FromQuery(Name = "orderBy")]
    public string? OrderBy { get; set; }

    [FromQuery(Name = "top")]
    public int? Top { get; set; }

    [FromQuery(Name = "skipToken")]
    public string? SkipToken { get; set; }

    [FromQuery(Name = "expand")]
    public string? Expand { get; set; }
}
