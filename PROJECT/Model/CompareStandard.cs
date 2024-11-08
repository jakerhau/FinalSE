using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PROJECT.Model
{
    public class CompareStandard
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        [BsonElement("Turbidity")]
        public List<double>? Turbidity { get; set; }

        [BsonElement("PH")]
        public List<double>? PH { get; set; }

        [BsonElement("TotalDissolvedSolids")]
        public List<double>? TotalDissolvedSolids { get; set; }

        [BsonElement("ColorDegree")]
        public List<double>? ColorDegree { get; set; }

        [BsonElement("TotalSuspendedSolids")]
        public List<double>? TotalSuspendedSolids { get; set; }

        [BsonElement("BOD")]
        public List<double>? BOD { get; set; }

        [BsonElement("COD")]
        public List<double>? COD { get; set; }

        [BsonElement("Ammonia")]
        public List<double>? Ammonia { get; set; }

        [BsonElement("TotalPhosphorus")]
        public List<double>? TotalPhosphorus { get; set; }

        [BsonElement("TotalNitrogen")]
        public List<double>? TotalNitrogen { get; set; }

        [BsonElement("Sulfide")]
        public List<double>? Sulfide { get; set; }

        [BsonElement("TotalMineralOil")]
        public List<double>? TotalMineralOil { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }
    }
}
