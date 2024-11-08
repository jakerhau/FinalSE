using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;


namespace PROJECT.Model
{
    public class Sample
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        [BsonElement("Turbidity"), BsonRepresentation(BsonType.Double)]
        public double Turbidity { get; set; }

        [BsonElement("PH"), BsonRepresentation(BsonType.Double)]
        public double PH { get; set; }

        [BsonElement("TotalDissolvedSolids"), BsonRepresentation(BsonType.Double)]
        public double TotalDissolvedSolids { get; set; }

        [BsonElement("ColorDegree"), BsonRepresentation(BsonType.Double)]
        public double ColorDegree { get; set; }

        [BsonElement("TotalSuspendedSolids"), BsonRepresentation(BsonType.Double)]
        public double TotalSuspendedSolids { get; set; }

        [BsonElement("BOD"), BsonRepresentation(BsonType.Double)]
        public double BOD { get; set; }

        [BsonElement("COD"), BsonRepresentation(BsonType.Double)]
        public double COD { get; set; }

        [BsonElement("Ammonia"), BsonRepresentation(BsonType.Double)]
        public double Ammonia { get; set; }

        [BsonElement("TotalPhosphorus"), BsonRepresentation(BsonType.Double)]
        public double TotalPhosphorus { get; set; }

        [BsonElement("TotalNitrogen"), BsonRepresentation(BsonType.Double)]
        public double TotalNitrogen { get; set; }

        [BsonElement("Sulfide"), BsonRepresentation(BsonType.Double)]
        public double Sulfide { get; set; }

        [BsonElement("TotalMineralOil"), BsonRepresentation(BsonType.Double)]
        public double TotalMineralOil { get; set; }

        [BsonElement("IdStatus"), BsonRepresentation(BsonType.ObjectId)]
        public ObjectId IdStatus { get; set; }

        [BsonElement("Name"), BsonRepresentation(BsonType.String)]
        public string Name { get; set; }

        //IdSam
        [BsonElement("IdSam"), BsonRepresentation(BsonType.Int32)]
        public int IdSam { get; set; }

    }
}
