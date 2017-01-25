using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class ListOfStockIndex
    {
        List<StockIndex> listOfStockIndex;

        public ListOfStockIndex()
        {
            listOfStockIndex = new List<StockIndex>();
        }
        public void addStockIndex(StockIndex stockIndex)
        {
            listOfStockIndex.Add(stockIndex);
        }
    }
}
