using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    abstract class SaveDataToDatabase
    {
        protected DbConnection connection;
        protected string whatSave;
        public SaveDataToDatabase()
        {
            connection = DbConnection.Instance;
        }

        public void save(ListOfData list)
        {
            whatSave += list.TimeOfUpdate;
            var collection = connection.Db.GetCollection<BsonDocument>(whatSave);
            var count = collection.AsQueryable().ToList().Count;

            if(count==0)
                foreach (var elem in list.ListData)
                {
                    var document = preparedBsonDocument(elem);
                    collection.InsertOne(document);
                }         
         }

        abstract public BsonDocument preparedBsonDocument(Data elem);

        public string WhatSave
        {
            set { whatSave = value; }
        }
    }
}
