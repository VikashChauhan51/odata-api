using System.Text.Json.Serialization;

namespace OdataServiceApi.Query;

public class QueryResponse<T> where T : class
{

    [JsonPropertyOrder(0)]
    public ICollection<T> Data { get; set; } = [];

    [JsonPropertyOrder(1)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IEnumerable<object>? Included { get; set; }

    [JsonPropertyOrder(2)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public QueryLinks? Links { get; set; }

    [JsonPropertyOrder(3)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public QueryMeta? Meta { get; set; }
}

