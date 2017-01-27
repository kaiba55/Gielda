using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class ListOfCurrency
    {
        List<Currency> listCurrenct;
        public ListOfCurrency()
        {
            listCurrenct = new List<Currency>();
        }

        void add(Currency currency)
        {
            listCurrenct.Add(currency);
        }
    }
}
