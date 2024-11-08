using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace PROJECT.Model
{
    internal class Target
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        private ObjectId Id { get; set; }

        [BsonElement("IdSample"), BsonRepresentation(BsonType.ObjectId)]
        private ObjectId SampleId { get; set; }

        [BsonElement("Turbidity"), BsonRepresentation(BsonType.Double)]
        private double Turbidity { get; set; }

        [BsonElement("PH"), BsonRepresentation(BsonType.Double)]
        private double Ph { get; set; }

        [BsonElement("TotalDissolvedSolids"), BsonRepresentation(BsonType.Double)]
        private double TotalDissolvedSolids { get; set; }

        [BsonElement("ColorDegree"), BsonRepresentation(BsonType.String)]
        private string ColorDegree { get; set; }

        [BsonElement("TotalSuspendedSolids"), BsonRepresentation(BsonType.Double)]
        private double TotalSuspendedSolids { get; set; }

        [BsonElement("BOD"), BsonRepresentation(BsonType.Double)]
        private double Bod { get; set; }

        [BsonElement("COD"), BsonRepresentation(BsonType.Double)]
        private double Cod { get; set; }

        [BsonElement("Ammonia"), BsonRepresentation(BsonType.Double)]
        private double Ammonia { get; set; }

        [BsonElement("TotalPhosphorus"), BsonRepresentation(BsonType.Double)]
        private double TotalPhosphorus { get; set; }

        [BsonElement("TotalNitrogen"), BsonRepresentation(BsonType.Double)]
        private double TotalNitrogen { get; set; }

        [BsonElement("Sulfide"), BsonRepresentation(BsonType.Double)]
        private double Sulfide { get; set; }

        [BsonElement("TotalMineralOil"), BsonRepresentation(BsonType.Double)]
        private double TotalMineralOil { get; set; }

        [BsonElement("AddTarget"), BsonRepresentation(BsonType.String)]
        private string AddTarget { get; set; }


    }
}
