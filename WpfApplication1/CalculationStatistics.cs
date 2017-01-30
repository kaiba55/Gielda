using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class CalculationStatistics
    {

        public string maxValue(List<Data> listData)
        {
            var max = listData.Max(x => x.Value);
            var name = listData.Where(elem => elem.Value == max);
            return name.First().Name + ": " + max.ToString();
        }
        public string minValue(List<Data> listData)
        {
            var min = listData.Min(x => x.Value);
            var name = listData.Where(elem => elem.Value == min);
            return name.First().Name + ": " + min.ToString();
        }
        public string maxChange(List<Data> listData)
        {
            return listData.Max(x => x.Change).ToString();
        }
        public string minChange(List<Data> listData)
        {
            return listData.Min(x => x.Change).ToString();
        }
        public string maxChangePercent(List<Data> listData)
        {
            return listData.Max(x => x.ChangePercent).ToString();
        }
        public string minChangePercent(List<Data> listData)
        {
            return listData.Min(x => x.ChangePercent).ToString();
        }
    }
}
