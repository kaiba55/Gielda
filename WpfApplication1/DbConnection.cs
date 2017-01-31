using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
namespace WpfApplication1
{
    class DbConnection
    {
        private static DbConnection instance;
        private static IMongoDatabase db;
        private DbConnection() { }

        public static DbConnection Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DbConnection();
                    MongoClientSettings settings = new MongoClientSettings();
                    settings.Server = new MongoServerAddress("localhost", 27017);
                    MongoClient client = new MongoClient(settings);
                    db = client.GetDatabase("Gielda");
                }
                return instance;
            }
        }

        public IMongoDatabase Db
        {
            get { return db; }
        }

        public List<string> listOfCollection(string type)
        {
            List<string> list = new List<string>();
            List<string> list2 = new List<string>();
            var listOfCollection = db.ListCollections().ToList();

            foreach (var x in listOfCollection)
            {
                list.Add(x["name"].AsString);
            }

            foreach (var x in list.Where(w => w.StartsWith(type)))
            {
                list2.Add(x);
            }

            for (int i=0;i<list2.Count;++i)
            {
                list2[i]=list2[i].Replace(type, "");
            }
           
            return list2;
        }
    }
}
