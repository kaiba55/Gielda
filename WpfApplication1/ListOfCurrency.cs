using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class ListOfCurrency
    {
        private List<Currency> listCurrenct;
        public ListOfCurrency()
        {
            listCurrenct = new List<Currency>();
        }

        public void addCurrency(Currency currency)
        {
            listCurrenct.Add(currency);
        }

        public List<Currency> ListCurrenct
        {
            get { return listCurrenct; }
        }

    }
}
