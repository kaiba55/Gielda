using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class ListOfData
    {
        protected List<Data> listData;
        public ListOfData()
        {
            listData = new List<Data>();
        }
        public void addData(Data data)
        {
            listData.Add(data);
        }
    }
}
