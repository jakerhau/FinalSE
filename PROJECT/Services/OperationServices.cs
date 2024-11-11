using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using PROJECT.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Services
{
    public class OperationServices
    {
        public static void RecordLogin(ObjectId idUser)
        {
            var operation = MongoHelper.GetDatabase().GetCollection<BsonDocument>("Operation");
            var filter = Builders<BsonDocument>.Filter.Eq("IdUser", idUser);
            var update = Builders<BsonDocument>.Update.Push("LoginTime", DateTime.Now);
            var result = operation.UpdateOne(filter, update);
            if (result.ModifiedCount > 0)
            {
                Debug.WriteLine("User login time added successfully.");
            }
            else
            {
                Debug.WriteLine("User login time added failed.");
            }
        }
        public static void RecordLogout(ObjectId idUser)
        {
            var operation = MongoHelper.GetDatabase().GetCollection<BsonDocument>("Operation");
            var filter = Builders<BsonDocument>.Filter.Eq("IdUser", idUser);
            var update = Builders<BsonDocument>.Update.Push("LogoutTime", DateTime.Now);
            var result = operation.UpdateOne(filter, update);
            if (result.ModifiedCount > 0)
            {
                Debug.WriteLine("User logout time added successfully.");
            }
            else
            {
                Debug.WriteLine("User logout time added failed.");
            }
        }
        public static void RecordStatisticalMerge(ObjectId idUser)
        {
            var operation = MongoHelper.GetDatabase().GetCollection<BsonDocument>("Operation");
            var filter = Builders<BsonDocument>.Filter.Eq("IdUser", idUser);
            var update = Builders<BsonDocument>.Update.Push("ContractStatistics", DateTime.Now);
            var result = operation.UpdateOne(filter, update);
            if (result.ModifiedCount > 0)
            {
                Debug.WriteLine("User statistical merge added successfully.");
            }
            else
            {
                Debug.WriteLine("User statistical merge added failed.");
            }
        }
        public static void RecordStatisticalCustomer(ObjectId idUser)
        {
            var operation = MongoHelper.GetDatabase().GetCollection<BsonDocument>("Operation");
            var filter = Builders<BsonDocument>.Filter.Eq("IdUser", idUser);
            var update = Builders<BsonDocument>.Update.Push("CustomerStatistics", DateTime.Now);
            var result = operation.UpdateOne(filter, update);
            if (result.ModifiedCount > 0)
            {
                Debug.WriteLine("User statistical customer added successfully.");
            }
            else
            {
                Debug.WriteLine("User statistical customer added failed.");
            }
        }
        //ExportReport
        public static void RecordExportReport(ObjectId idUser)
        {
            var operation = MongoHelper.GetDatabase().GetCollection<BsonDocument>("Operation");
            var filter = Builders<BsonDocument>.Filter.Eq("IdUser", idUser);
            var update = Builders<BsonDocument>.Update.Push("ExportReport", DateTime.Now);
            var result = operation.UpdateOne(filter, update);
            if (result.ModifiedCount > 0)
            {
                Debug.WriteLine("User export report added successfully.");
            }
            else
            {
                Debug.WriteLine("User export report added failed.");
            }
        }
        //InputTime
        public static void RecordInputTime(ObjectId idUser)
        {
            var operation = MongoHelper.GetDatabase().GetCollection<BsonDocument>("Operation");
            var filter = Builders<BsonDocument>.Filter.Eq("IdUser", idUser);
            var update = Builders<BsonDocument>.Update.Push("InputTime", DateTime.Now);
            var result = operation.UpdateOne(filter, update);
            if (result.ModifiedCount > 0)
            {
                Debug.WriteLine("User input time added successfully.");
            }
            else
            {
                Debug.WriteLine("User input time added failed.");
            }
        }
    }
}
