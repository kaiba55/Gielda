using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class CalculationStatisticsForStockIndex:CalculationStatisticsForData
    {
        public override string minMoneyTurnover(List<Data> listData)
        {
            var min = listData.Min(x => x.MoneyTurnover);
            var name = listData.Where(elem => elem.MoneyTurnover == min);
            if (name.Count() == 1)
                return name.First().Name + ": " + min.ToString();
            else
            {
                string temp = null;
                foreach (var x in name)
                {
                    temp += x.Name + ", ";
                }
                return temp + ": " + min.ToString();
            }
        }

        public override string maxMoneyTurnover(List<Data> listData)
        {
            var max = listData.Max(x => x.MoneyTurnover);
            var name = listData.Where(elem => elem.MoneyTurnover == max);
            if (name.Count() == 1)
                return name.First().Name + ": " + max.ToString();
            else
            {
                string temp = null;
                foreach (var x in name)
                {
                    temp += x.Name + ", ";
                }
                return temp + ": " + max.ToString();
            }
        }
    }
}
