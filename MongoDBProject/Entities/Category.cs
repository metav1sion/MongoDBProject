using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDBProject.Entities
{
    public class Category
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)] //id'nin benzersiz değerler almasını sağlıyor
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
