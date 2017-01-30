using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class ListOfCurrency
    {
        private List<Currency> listCurrency;
        protected string timeOfUpdate;
        public ListOfCurrency()
        {
            listCurrency = new List<Currency>();
        }

        public void addCurrency(Currency currency)
        {
            listCurrency.Add(currency);
        }

        public List<Currency> ListCurrency
        {
            get { return listCurrency; }
        }

        public string TimeOfUpdate
        {
            get { return timeOfUpdate; }
            set { timeOfUpdate = value; }
        }

    }
}
