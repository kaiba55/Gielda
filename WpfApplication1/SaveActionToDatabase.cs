using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace WpfApplication1
{
    class SaveActionToDatabase : SaveDataToDatabase
    {
        public override BsonDocument preparedBsonDocument(Data elem)
        {
                BsonDocument document = new BsonDocument
                {
                    { "name", elem.Name },
                    { "value",elem.Value },
                    { "change",elem.Change},
                    { "changePercent", elem.ChangePercent },
                    { "opening", elem.Opening},
                    { "numberOfTransaction", elem.NumberOfTransaction },
                    { "max", elem.Max },
                    { "min", elem.Min },
                    { "moneyTurnover",elem.MoneyTurnover },
                    { "time", elem.Time }
                };
            return document;
         }
    }
}
