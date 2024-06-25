namespace MongoDBProject.Settings;

public interface IDatabaseSettings
{
    public string CategoryCollectionName { get; set; } //Collection tablo adı demek
    public string ProductCollectionName { get; set; } //Collection tablo adı demek
    public string ConnectionString { get; set; }
    public string DatabaseName { get; set; }
}