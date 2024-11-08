using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PROJECT.Model
{
    public class User
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        [BsonElement("DateOfBirth"), BsonRepresentation(BsonType.DateTime)]
        private DateTime DateOfBirth { get; set; }

        [BsonElement("UserName"), BsonRepresentation(BsonType.String)]
        public string Username { get; set; }

        [BsonElement("Email"), BsonRepresentation(BsonType.String)]
        public string Email { get; set; }

        [BsonElement("Password"), BsonRepresentation(BsonType.String)]

        public string Password { get; set; }

        
        [BsonElement("Department"), BsonRepresentation(BsonType.String)]
        private string Department { get; set; }

        [BsonElement("Permit"), BsonRepresentation(BsonType.String)]
        private string Permit { get; set; }

        //IdAdmin
        [BsonElement("IdAdmin"), BsonRepresentation(BsonType.ObjectId)]
        private ObjectId IdAdmin { get; set; }

    }
}
