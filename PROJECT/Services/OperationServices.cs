using MongoDB.Bson;
using MongoDB.Driver;
using PROJECT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.Services
{
    public class OperationServices
    {
        private readonly IMongoCollection<Operation> _operationCollection;
        public OperationServices()
        {
            _operationCollection = MongoHelper.GetCollection<Operation>("operations");
        }
        public async Task RecordLoginTime(string userId)
        {
            var filter = Builders<Operation>.Filter.Eq(o => o.IdUser, new ObjectId(userId));

            var update = Builders<Operation>.Update.Push(o => o.LoginTime, DateTime.UtcNow);

            var result = await _operationCollection.UpdateOneAsync(filter, update);

            if (result.ModifiedCount > 0)
            {
                Console.WriteLine("Login time recorded successfully.");
            }
            else
            {
                Console.WriteLine("Failed to record login time or user not found.");
            }
        }
        public async Task RecordLogoutTime(string userId)
        {
            var filter = Builders<Operation>.Filter.Eq(o => o.IdUser, new ObjectId(userId));
            var update = Builders<Operation>.Update.Push(o => o.LogoutTime, DateTime.UtcNow);
            var result = await _operationCollection.UpdateOneAsync(filter, update);

            if (result.ModifiedCount > 0)
            {
                Console.WriteLine("Logout time recorded successfully.");
            }
            else
            {
                Console.WriteLine("Failed to record logout time or user not found.");
            }
        }
        public async Task RecordStatisticalMerge(string userId)
        {
            var filter = Builders<Operation>.Filter.Eq(o => o.IdUser, new ObjectId(userId));
            var update = Builders<Operation>.Update.Push(o => o.StatisticalMerge, DateTime.UtcNow);
            var result = await _operationCollection.UpdateOneAsync(filter, update);

            if (result.ModifiedCount > 0)
            {
                Console.WriteLine("Statistical Merge time recorded successfully.");
            }
            else
            {
                Console.WriteLine("Failed to record statistical merge time or user not found.");
            }
        }
        public async Task RecordStatisticalCustomer(string userId)
        {
            var filter = Builders<Operation>.Filter.Eq(o => o.IdUser, new ObjectId(userId));
            var update = Builders<Operation>.Update.Push(o => o.StatisticalCustomer, DateTime.UtcNow);
            var result = await _operationCollection.UpdateOneAsync(filter, update);

            if (result.ModifiedCount > 0)
            {
                Console.WriteLine("Statistical Customer time recorded successfully.");
            }
            else
            {
                Console.WriteLine("Failed to record statistical customer time or user not found.");
            }
        }
        public async Task RecordExportReport(string userId)
        {
            var filter = Builders<Operation>.Filter.Eq(o => o.IdUser, new ObjectId(userId));
            var update = Builders<Operation>.Update.Push(o => o.ExportReport, DateTime.UtcNow);
            var result = await _operationCollection.UpdateOneAsync(filter, update);

            if (result.ModifiedCount > 0)
            {
                Console.WriteLine("Export Report time recorded successfully.");
            }
            else
            {
                Console.WriteLine("Failed to record export report time or user not found.");
            }
        }
        public async Task RecordInputTime(string userId)
        {
            var filter = Builders<Operation>.Filter.Eq(o => o.IdUser, new ObjectId(userId));
            var update = Builders<Operation>.Update.Push(o => o.InputTime, DateTime.UtcNow);
            var result = await _operationCollection.UpdateOneAsync(filter, update);

            if (result.ModifiedCount > 0)
            {
                Console.WriteLine("Input Time recorded successfully.");
            }
            else
            {
                Console.WriteLine("Failed to record input time or user not found.");
            }
        }

    }
}
