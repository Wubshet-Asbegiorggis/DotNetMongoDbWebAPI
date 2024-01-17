using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MongoDotnetDemo.Models
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string? ProductName { get; set; }

        [BsonRepresentation(BsonType.ObjectId)] 
        public string? CategoryId { get; set; }

        // This property, will not store in database, if you pass a null value to it, so make sure make it null before passing to db
        [BsonIgnoreIfNull]
        public string? CategoryName { get; set; }
    }
}
