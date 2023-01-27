namespace Data.Mongo;

public interface IMongoDbSettings
{
    string DatabaseName { get; set; }
    string ConnectionString { get; set; }
}

public class MongoDbOptions : IMongoDbSettings
{
    public string DatabaseName { get; set; }
    public string ConnectionString { get; set; }
}