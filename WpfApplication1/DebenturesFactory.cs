using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class DebenturesFactory : DataFactory
    {
        public Data produce(string name, List<double> listOfArguments, string time)
        {
            return new Debentures(name, listOfArguments, time);
        }
    }
}
