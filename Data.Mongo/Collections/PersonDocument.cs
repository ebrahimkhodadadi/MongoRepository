using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace Data.Mongo.Collections;

public class PersonDocument : MongoBaseDocument
{
    public string Name { get; set; }
    public string Family { get; set; }

    [JsonPropertyName("Properties")]
    [BsonSerializer(typeof(MongoDictionarySerializer))]
    public Dictionary<string, object>? Properties { get; set; }
}
