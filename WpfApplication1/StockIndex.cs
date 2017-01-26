using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    //indeks gieldowy
    //dotyczy http://www.bankier.pl/gielda/notowania/indeksy-gpw
    class StockIndex:Data
    {
        public StockIndex(string name, List<double> listOfArguments, string time):base(name,listOfArguments,time)
        {

        }
    }
}
