using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class Currency
    {
        private string name;
        private string symbol;
        private double purchaseValue;
        private double purchaseChange;
        private double purchaseChangePercent;
        private double saleValue;
        private double saleChange;
        private double saleChangePercent;

        public Currency(string name, string symbol, List<double>arguments)
        {
            this.name = name;
            this.symbol = symbol;
            purchaseValue = arguments[0];
            purchaseChange= arguments[1];
            purchaseChangePercent= arguments[2];
            saleValue = arguments[3];
            saleChange = arguments[4];
            saleChangePercent = arguments[5];
        }
    }
}
