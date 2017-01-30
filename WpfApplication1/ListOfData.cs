using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    abstract class ListOfData
    {
        protected List<Data> listData;
        protected string timeOfUpdate;
        public ListOfData()
        {
            listData = new List<Data>();
        }
        public void addData(Data data)
        {
            listData.Add(data);
        }

        public int sizeOfList()
        {
            return listData.Count;
        }

        public List<Data> ListData
        {
            get { return listData; }
        }

        public string TimeOfUpdate
        {
            get { return timeOfUpdate; }
            set { timeOfUpdate = value; }
        }
    }
}
