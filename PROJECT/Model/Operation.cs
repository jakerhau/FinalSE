using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace PROJECT.Model
{
    public class Operation
    {
        [BsonId, BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        //IdUser
        public ObjectId IdUser { get; set; }

        //LoginTime
        public List<DateTime> LoginTime { get; set; }
        public List<DateTime> LogoutTime { get; set; }
        public List<DateTime> StatisticalMerge { get; set; }
        public List<DateTime> StatisticalCustomer { get; set; }
        public List<DateTime> ExportReport { get; set; }
        public List<DateTime> InputTime { get; set; }
    }
}
