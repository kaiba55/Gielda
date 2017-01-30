using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class CalculationStatisticsForCurrency
    {
        public string maxPurchaseValue(List<Currency> listCurrency)
        {
            var max = listCurrency.Max(x => x.PurchaseValue);
            var name = listCurrency.Where(elem => elem.PurchaseValue == max);
            if (name.Count() == 1)
                return name.First().Symbol + ": " + max.ToString();
            else
            {
                string temp = null;
                foreach (var x in name)
                {
                    temp += x.Symbol + ", ";
                }
                return temp + ": " + max.ToString();
            }
        }
        public string minPurchaseValue(List<Currency> listCurrency)
        {
            var min = listCurrency.Min(x => x.PurchaseValue);
            var name = listCurrency.Where(elem => elem.PurchaseValue == min);
            if (name.Count() == 1)
                return name.First().Symbol + ": " + min.ToString();
            else
            {
                string temp = null;
                foreach (var x in name)
                {
                    temp += x.Symbol + ", ";
                }
                return temp + ": " + min.ToString();
            }
        }
        public string maxPurchaseChange(List<Currency> listCurrency)
        {
            var max = listCurrency.Max(x => x.PurchaseChange);
            var name = listCurrency.Where(elem => elem.PurchaseChange == max);
            if (name.Count() == 1)
                return name.First().Symbol + ": " + max.ToString();
            else
            {
                string temp = null;
                foreach (var x in name)
                {
                    temp += x.Symbol + ", ";
                }
                return temp + ": " + max.ToString();
            }
        }
        public string minPurchaseChange(List<Currency> listCurrency)
        {
            var min = listCurrency.Min(x => x.PurchaseChange);
            var name = listCurrency.Where(elem => elem.PurchaseChange == min);
            if (name.Count() == 1)
                return name.First().Symbol + ": " + min.ToString();
            else
            {
                string temp = null;
                foreach (var x in name)
                {
                    temp += x.Symbol + ", ";
                }
                return temp + ": " + min.ToString();
            }
        }

        public string maxPurchaseChangePercent(List<Currency> listCurrency)
        {
            var max = listCurrency.Max(x => x.PurchaseChangePercent);
            var name = listCurrency.Where(elem => elem.PurchaseChangePercent == max);
            if (name.Count() == 1)
                return name.First().Symbol + ": " + max.ToString();
            else
            {
                string temp = null;
                foreach (var x in name)
                {
                    temp += x.Symbol + ", ";
                }
                return temp + ": " + max.ToString();
            }
        }
        public string minPurchaseChangePercent(List<Currency> listCurrency)
        {
            var min = listCurrency.Min(x => x.PurchaseChangePercent);
            var name = listCurrency.Where(elem => elem.PurchaseChange == min);
            if (name.Count() == 1)
                return name.First().Symbol + ": " + min.ToString();
            else
            {
                string temp = null;
                foreach (var x in name)
                {
                    temp += x.Symbol + ", ";
                }
                return temp + ": " + min.ToString();
            }
        }

        public string maxSaleValue(List<Currency> listCurrency)
        {
            var max = listCurrency.Max(x => x.SaleValue);
            var name = listCurrency.Where(elem => elem.SaleValue == max);
            if (name.Count() == 1)
                return name.First().Symbol + ": " + max.ToString();
            else
            {
                string temp = null;
                foreach (var x in name)
                {
                    temp += x.Symbol + ", ";
                }
                return temp + ": " + max.ToString();
            }
        }
        public string minSaleValue(List<Currency> listCurrency)
        {
            var min = listCurrency.Min(x => x.SaleValue);
            var name = listCurrency.Where(elem => elem.SaleValue == min);
            if (name.Count() == 1)
                return name.First().Symbol + ": " + min.ToString();
            else
            {
                string temp = null;
                foreach (var x in name)
                {
                    temp += x.Symbol + ", ";
                }
                return temp + ": " + min.ToString();
            }
        }
        public string maxSaleChange(List<Currency> listCurrency)
        {
            var max = listCurrency.Max(x => x.SaleChange);
            var name = listCurrency.Where(elem => elem.SaleChange == max);
            if (name.Count() == 1)
                return name.First().Symbol + ": " + max.ToString();
            else
            {
                string temp = null;
                foreach (var x in name)
                {
                    temp += x.Symbol + ", ";
                }
                return temp + ": " + max.ToString();
            }
        }
        public string minSaleChange(List<Currency> listCurrency)
        {
            var min = listCurrency.Min(x => x.SaleChange);
            var name = listCurrency.Where(elem => elem.SaleChange == min);
            if (name.Count() == 1)
                return name.First().Symbol + ": " + min.ToString();
            else
            {
                string temp = null;
                foreach (var x in name)
                {
                    temp += x.Symbol + ", ";
                }
                return temp + ": " + min.ToString();
            }
        }

        public string maxSaleChangePercent(List<Currency> listCurrency)
        {
            var max = listCurrency.Max(x => x.SaleChangePercent);
            var name = listCurrency.Where(elem => elem.SaleChangePercent == max);
            if (name.Count() == 1)
                return name.First().Symbol + ": " + max.ToString();
            else
            {
                string temp = null;
                foreach (var x in name)
                {
                    temp += x.Symbol + ", ";
                }
                return temp + ": " + max.ToString();
            }
        }
        public string minSaleChangePercent(List<Currency> listCurrency)
        {
            var min = listCurrency.Min(x => x.SaleChangePercent);
            var name = listCurrency.Where(elem => elem.SaleChange == min);
            if (name.Count() == 1)
                return name.First().Symbol + ": " + min.ToString();
            else
            {
                string temp = null;
                foreach (var x in name)
                {
                    temp += x.Symbol + ", ";
                }
                return temp + ": " + min.ToString();
            }
        }
    }
}
