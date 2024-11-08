using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace PROJECT.Model
{
    public class ContractModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        //DayStart
        [BsonElement("DayStart"), BsonRepresentation(BsonType.DateTime)]
        public DateTime DayStart { get; set; }

        //DayEnd
        [BsonElement("DayEnd"), BsonRepresentation(BsonType.DateTime)]
        public DateTime DayEnd { get; set; }

        //IdStatus
        //[BsonElement("IdStatus"), BsonRepresentation(BsonType.ObjectId)]
        //public ObjectId IdStatus { get; set; }

        //NumberContract int32
        [BsonElement("NumberContract"), BsonRepresentation(BsonType.Int32)]
        public int Status { get; set; }

        //IdUser
        [BsonElement("IdUser"), BsonRepresentation(BsonType.ObjectId)]
        public ObjectId IdUser { get; set; }

        //IdCustomer
        [BsonElement("IdCustomer"), BsonRepresentation(BsonType.ObjectId)]
        public ObjectId IdCustomer { get; set; }
    }
}
