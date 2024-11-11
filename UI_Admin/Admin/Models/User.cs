using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Admin.Models
{
    public class User
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        [BsonElement("IdOperation"), BsonRepresentation(BsonType.ObjectId)]
        private ObjectId OperationId { get; set; }

        [BsonElement("UserName"), BsonRepresentation(BsonType.String)]
        public string Username { get; set; }

        [BsonElement("Email"), BsonRepresentation(BsonType.String)]
        public string Email { get; set; }

        [BsonElement("Password"), BsonRepresentation(BsonType.String)]

        public string Password { get; set; }

        
        [BsonElement("Department"), BsonRepresentation(BsonType.String)]
        public string Department { get; set; }

        [BsonElement("Permit"), BsonRepresentation(BsonType.String)]
        public string Permit { get; set; }

        //IdAdmin
        [BsonElement("IdAdmin"), BsonRepresentation(BsonType.ObjectId)]
        public ObjectId IdAdmin { get; set; }

        //DayOfBirth
        [BsonElement("DateOfBirth"), BsonRepresentation(BsonType.DateTime)]
        public DateTime DayOfBirth { get; set; }

        //hash password
        public string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
    }
}
