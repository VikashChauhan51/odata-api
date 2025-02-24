using OdataServiceApi.Resources;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OdataServiceApi.Query.Json;

public class QueryResponseJsonConverter<T> : JsonConverter<QueryResponse<T>> where T : class, IResource
{

    public override QueryResponse<T>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }

    public override void Write(Utf8JsonWriter writer, QueryResponse<T> value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}
