using Data.Mongo.Attributes;
using MongoDB.Bson.Serialization.Attributes;


namespace Data.Mongo.Collections;

[BsonCollection("Log")]
[BsonIgnoreExtraElements]
public class Log : MongoBaseDocument
{
    public LogType LogType { get; set; }
    public string Code { get; set; }
    public int ClientID { get; set; }
    public DateTime Created { get; set; }
}

public class LogType
{
    public int key { get; set; }
    public string value { get; set; }
}