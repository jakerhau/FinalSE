using MongoDB.Driver;


namespace Admin.Models
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
        public static IMongoCollection<AdminModel> GetAdminCollection()
        {
            return GetDatabase().GetCollection<AdminModel>("Admin");
        }
    }
}
