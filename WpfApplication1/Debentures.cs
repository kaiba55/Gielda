using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    //obligacje
    class Debentures:Data
    {
        public Debentures()
        {

        }
        public Debentures(string name, List<double> listOfArguments, string time)
        {
            this.name = name;
            this.value = listOfArguments[0];
            this.change = listOfArguments[1];
            this.changePercent = listOfArguments[2];
            this.opening = listOfArguments[3];
            this.max = listOfArguments[4];
            this.min = listOfArguments[5];
            this.time = time;
        }
    }
}
