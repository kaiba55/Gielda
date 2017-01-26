using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Windows.Controls;

namespace WpfApplication1
{
    //akcje stąd http://www.bankier.pl/gielda/notowania/akcje
    class Action:Data
    {
        public Action(string name, List<double> listOfArguments, string time):base(name,listOfArguments,time)
        {

        }
    }
}
