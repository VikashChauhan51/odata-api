using System.Text.Json.Serialization;

namespace OdataServiceApi.Query;

public class QueryLinks
{
    public string Self { get; set; } = null!;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Next { get; set; }
}
