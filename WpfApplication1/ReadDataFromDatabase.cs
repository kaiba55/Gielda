using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    abstract class ReadDataFromDatabase
    {
        protected DbConnection connection;
        protected string whatRead;
        protected IDataFactory factory;
        public ReadDataFromDatabase()
        {
            connection = DbConnection.Instance;
        }

        public void read(ListOfData list)
        {
            list.ListData.Clear();
            var collection = connection.Db.GetCollection<BsonDocument>(whatRead);
            var books = collection.AsQueryable();
            List<BsonDocument> list2 = books.ToList();

            foreach (var elem in list2)
            {
                list.addData(readElement(elem));  
            }
        }

        public abstract Data readElement(BsonDocument elem);

        public string WhatRead
        {
            set { whatRead = value; }
        }
    }
}
