using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Admin.Models
{
    public class Operation
    {
        [BsonId, BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        [BsonElement("IdUser"), BsonRepresentation(BsonType.ObjectId)]
        public ObjectId IdUser { get; set; }

        [BsonElement("LoginTime")]
        public List<DateTime> LoginTime { get; set; }

        [BsonElement("LogoutTime")]
        public List<DateTime> LogoutTime { get; set; }

        [BsonElement("StatisticalMerge")]
        public List<DateTime> StatisticalMerge { get; set; }

        [BsonElement("StatisticalCustomer")]
        public List<DateTime> StatisticalCustomer { get; set; }

        [BsonElement("ExportReport")]
        public List<DateTime> ExportReport { get; set; }

        [BsonElement("InputTime")]
        public List<DateTime> InputTime { get; set; }
    }
}
