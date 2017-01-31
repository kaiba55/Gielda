using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    interface IDataFactory
    {
        Data produce(string name, List<double> listOfArguments, string time);
    }
}
