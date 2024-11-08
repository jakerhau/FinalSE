using Microsoft.AspNetCore.JsonPatch.Operations;
using MongoDB.Driver;


namespace PROJECT.Model
{
    public class MongoHelper
    {
        private static IMongoClient client;
        private static IMongoDatabase database;

        private static readonly string MongoConnection =
            "mongodb+srv://nxuandao1:52200294@cluster0.x11gh.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0";
        private static readonly string MongoDatabase = "FinalReportDatabase";

        // Đảm bảo chỉ khởi tạo một lần duy nhất
        public MongoHelper() { }

        public static IMongoDatabase GetDatabase()
        {
            if (database == null)
            {
                client = new MongoClient(MongoConnection);
                database = client.GetDatabase(MongoDatabase);
            }
            return database;
        }
        //get User collection
        public static IMongoCollection<User> GetUserCollection()
        {
            return GetDatabase().GetCollection<User>("User");
        }
        //get Operation collection
        public static IMongoCollection<Operation> GetOperationCollection()
        {
            return GetDatabase().GetCollection<Operation>("Operation");
        }
        //get Admin collection
        public static IMongoCollection<Admin> GetAdminCollection()
        {
            return GetDatabase().GetCollection<Admin>("Admin");
        }
        //contract
        public static IMongoCollection<ContractModel> GetContractCollection()
        {
            return GetDatabase().GetCollection<ContractModel>("Contract");
        }
        //status
        public static IMongoCollection<Status> GetStatusCollection()
        {
            return GetDatabase().GetCollection<Status>("Status");
        }
        //customer
        public static IMongoCollection<Customer> GetCustomerCollection()
        {
            return GetDatabase().GetCollection<Customer>("Customers");
        }

        public static IMongoCollection<CompareStandard> GetCompareStandardCollection()
        {
            return GetDatabase().GetCollection<CompareStandard>("CompareStandard");
        }
        //Sample
        public static IMongoCollection<Sample> GetSampleCollection()
        {
            return GetDatabase().GetCollection<Sample>("Sample");
        }
        //Result
        public static IMongoCollection<Result> GetResultCollection()
        {
            return GetDatabase().GetCollection<Result>("Result");
        }
        public static IMongoCollection<T> GetCollection<T>(string collectionName)
        {
            return GetDatabase().GetCollection<T>(collectionName);
        }
    }
}
