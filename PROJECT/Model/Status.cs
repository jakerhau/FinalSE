using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
namespace PROJECT.Model
{
    public class Status
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        [BsonElement("IdResult"), BsonRepresentation(BsonType.ObjectId)]
        public ObjectId IdResult { get; set; }

        [BsonElement("TimeResult"), BsonRepresentation(BsonType.DateTime)]

        public DateTime TimeResult { get; set; }

        [BsonElement("IdCompare"), BsonRepresentation(BsonType.ObjectId)]
        public ObjectId IdCompare { get; set; }

        [BsonElement("Address"), BsonRepresentation(BsonType.String)]
        public string Address { get; set; }

        [BsonElement("GetTime"), BsonRepresentation(BsonType.DateTime)]

        public DateTime GetTime { get; set; }

        [BsonElement("Status"), BsonRepresentation(BsonType.String)]
        public string stt { get; set; }

        //IdContract
        [BsonElement("IdContract"), BsonRepresentation(BsonType.ObjectId)]
        public ObjectId IdContract { get; set; }

        [BsonElement("Deadline"), BsonRepresentation(BsonType.DateTime)]
        public DateTime Deadline { get; set; }
    }
}
