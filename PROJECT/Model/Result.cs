using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace PROJECT.Model
{
    public class Result
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        [BsonElement("Turbidity"), BsonRepresentation(BsonType.String)]
        public string Turbidity { get; set; }
        [BsonElement("PH"), BsonRepresentation(BsonType.String)]
        public string PH { get; set; }
        [BsonElement("TotalDissolvedSolids"), BsonRepresentation(BsonType.String)]
        public string TotalDissolvedSolids { get; set; }
        [BsonElement("ColorDegree"), BsonRepresentation(BsonType.String)]
        public string ColorDegree { get; set; }
        [BsonElement("TotalSuspendedSolids"), BsonRepresentation(BsonType.String)]
        public string TotalSuspendedSolids { get; set; }
        [BsonElement("BOD"), BsonRepresentation(BsonType.String)]
        public string BOD { get; set; }
        [BsonElement("COD"), BsonRepresentation(BsonType.String)]
        public string COD { get; set; }
        [BsonElement("Ammonia"), BsonRepresentation(BsonType.String)]
        public string Ammonia { get; set; }
        [BsonElement("TotalPhosphorus"), BsonRepresentation(BsonType.String)]
        public string TotalPhosphorus { get; set; }
        [BsonElement("TotalNitrogen"), BsonRepresentation(BsonType.String)]
        public string TotalNitrogen { get; set; }
        [BsonElement("Sulfide"), BsonRepresentation(BsonType.String)]
        public string Sulfide { get; set; }

        [BsonElement("TotalMineralOil"), BsonRepresentation(BsonType.String)]
        public string TotalMineralOil { get; set; }

        [BsonElement("IdStatus"), BsonRepresentation(BsonType.ObjectId)]
        public ObjectId IdStatus { get; set; }

        [BsonElement("IdSample"), BsonRepresentation(BsonType.ObjectId)]
        public ObjectId IdSample { get; set; }

    }
}
