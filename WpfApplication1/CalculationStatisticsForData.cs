using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    abstract class CalculationStatisticsForData
    {

        public string maxValue(List<Data> listData)
        {
            var max = listData.Max(x => x.Value);
            var name = listData.Where(elem => elem.Value == max);
            if(name.Count()==1)
                return name.First().Name + ": " + max.ToString();
            else
            {
                string temp=null;
                foreach(var x in name)
                {
                    temp += x.Name + ", ";
                }
                return temp + ": " + max.ToString();
            }
        }
        public string minValue(List<Data> listData)
        {
            var min = listData.Min(x => x.Value);
            var name = listData.Where(elem => elem.Value == min);
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
        public string maxChange(List<Data> listData)
        {
            var max = listData.Max(x => x.Change);
            var name = listData.Where(elem => elem.Change == max);
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
        public string minChange(List<Data> listData)
        {
            var min = listData.Min(x => x.Change);
            var name = listData.Where(elem => elem.Change == min);
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
        public string maxChangePercent(List<Data> listData)
        {
            var min = listData.Max(x => x.ChangePercent);
            var name = listData.Where(elem => elem.ChangePercent == min);
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
        public string minChangePercent(List<Data> listData)
        {
            var min = listData.Min(x => x.ChangePercent);
            var name = listData.Where(elem => elem.ChangePercent == min);
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

        public string maxOpening(List<Data> listData)
        {
            var min = listData.Max(x => x.Opening);
            var name = listData.Where(elem => elem.Opening == min);
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
        public string minOpening(List<Data> listData)
        {
            var min = listData.Min(x => x.Opening);
            var name = listData.Where(elem => elem.Opening == min);
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
        public virtual string maxTransaction(List<Data> listData)
        {
            return null;
        }

        public virtual string minMoneyTurnover(List<Data> listData)
        {
            return null;
        }

        public virtual string maxMoneyTurnover(List<Data> listData)
        {
            return null;
        }

    }
}
