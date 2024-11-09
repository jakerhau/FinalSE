
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace Admin.Models
{
    public class AdminModel
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        [BsonElement("Email"), BsonRepresentation(BsonType.String)]
        public string Email { get; set; }

        [BsonElement("Password"), BsonRepresentation(BsonType.String)]
        public string Password { get; set; }
    }
}