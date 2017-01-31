using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class CurrencyConverter
    {
        public double convert(ListOfCurrency list, string name1, string name2,string name3, double value)
        {
            double newValue=0.0;

            //przeliczamy ze zlotowek na inna walute
            if (name1.Equals("1 PLN"))
                if (name2.Equals("1 PLN"))
                    return value;
                else
                {
                    if (name3.Equals("Kursu sprzedaży"))
                    {
                        var x = list.ListCurrency.Find(w => w.Symbol.Equals(name2));
                        newValue = value /x.SaleValue;
                        return newValue;
                    }
                    else
                    {
                        var x = list.ListCurrency.Find(w => w.Symbol.Equals(name2));
                        newValue = value /x.PurchaseValue;
                        return newValue;
                    }
                }

            //przeliczamy na zlotowki
            if (name2.Equals("1 PLN"))
                if (name1.Equals("1 PLN"))
                    return value;
                else
                {
                    if (name3.Equals("Kursu sprzedaży"))
                    {
                        var x = list.ListCurrency.Find(w => w.Symbol.Equals(name1));
                        newValue = value *x.SaleValue;
                        return newValue;
                    }
                    else
                    {
                        var x = list.ListCurrency.Find(w => w.Symbol.Equals(name1));
                        newValue = value *x.PurchaseValue;
                        return newValue;
                    }
                }

            //przeliczamy inne waluty
            if (name3.Equals("Kursu sprzedaży"))
            {
                var x = list.ListCurrency.Find(w => w.Symbol.Equals(name2));
                double temp = value/x.SaleValue;
                var x2 = list.ListCurrency.Find(w => w.Symbol.Equals(name1));
                newValue = temp * x2.SaleValue;
                return newValue;
            }
            else
            {
                var x = list.ListCurrency.Find(w => w.Symbol.Equals(name2));
                double temp = value/x.PurchaseValue;
                var x2 = list.ListCurrency.Find(w => w.Symbol.Equals(name1));
                newValue = temp * x2.PurchaseValue;
                return newValue;
            }
        }
    }
}
