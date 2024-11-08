using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace PROJECT.Model
{
    public class Customer
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }
        [BsonElement("Name"), BsonRepresentation(BsonType.String)]
        public string Name { get; set; }

        //PhoneNumber int32
        [BsonElement("PhoneNumber"), BsonRepresentation(BsonType.Int32)]
        public int PhoneNumber { get; set; }

        //Address
        [BsonElement("Address"), BsonRepresentation(BsonType.String)]
        public string Address { get; set; }

        //EmailAddress
        [BsonElement("EmailAddress"), BsonRepresentation(BsonType.String)]
        public string EmailAddress { get; set; }

        //RepresentativeName
        [BsonElement("RepresentativeName"), BsonRepresentation(BsonType.String)]
        public string RepresentativeName { get; set; }

        //IdBusiness int32  
        [BsonElement("IdBusiness"), BsonRepresentation(BsonType.Int32)]
        public int IdBusiness { get; set; }
    }
}
