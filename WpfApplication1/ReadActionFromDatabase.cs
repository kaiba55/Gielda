using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class ReadActionFromDatabase : ReadDataFromDatabase
    {
        public ReadActionFromDatabase() : base()
        {
            factory = new ActionFactory();
        }
        public override Data readElement(BsonDocument elem)
        {
            string name= elem["name"].AsString;
            string time = elem["time"].AsString;
            List<double> listOfArguments = new List<double>();
            listOfArguments.Add(elem["value"].AsDouble);
            listOfArguments.Add(elem["change"].AsDouble);
            listOfArguments.Add(elem["changePercent"].AsDouble);
            listOfArguments.Add(elem["opening"].AsDouble);
            listOfArguments.Add(elem["numberOfTransaction"].AsDouble);
            listOfArguments.Add(elem["max"].AsDouble);
            listOfArguments.Add(elem["min"].AsDouble);
            listOfArguments.Add(elem["moneyTurnover"].AsDouble);
            return factory.produce(name, listOfArguments, time);
        }
    }
}
