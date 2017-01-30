using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace WpfApplication1
{
    class DownloadCurrency
    {
        private CurrencyValidator validator;
        public DownloadCurrency()
        {
            validator = new CurrencyValidator();
        }
        public void download(ListOfCurrency listCurrency)
        {
            string url = "http://www.bankier.pl/waluty/kursy-walut/nbp/kupno-sprzedaz";
            HtmlWeb web = new HtmlWeb();
            HtmlDocument document = web.Load(url);

            HtmlNode[] country = document.DocumentNode.SelectNodes("//td[@class='colWalor']//a").ToArray();
            HtmlNode[] symbol = document.DocumentNode.SelectNodes("//td[@class='textAlignRight']").ToArray();//z tego mamy symbol
            HtmlNode[] value = document.DocumentNode.SelectNodes("//td[@class='colKurs textAlignRight change  down' or @class='colKurs textAlignRight change  up' or @class='colKurs textAlignRight change ']").ToArray();//parzyste to zakupu, nieparzyste sprzedazy, czyli co 2
            HtmlNode[] change = document.DocumentNode.SelectNodes("//td[@class='textAlignRight change  down' or @class='textAlignRight change ' or @class='textAlignRight change  up' ]").ToArray();//co 4
            HtmlNode[] changePercent = document.DocumentNode.SelectNodes("//td[@class='textAlignRight change  down' or @class='textAlignRight change ' or @class='textAlignRight change  up' ]").ToArray();//co 4

            //pobranie nazwy walut
            url = "http://www.bankier.pl/waluty/kursy-walut/nbp";
            web = new HtmlWeb();
            document = web.Load(url);
            HtmlNode[] name = document.DocumentNode.SelectNodes("//td[@class='textAlignLeft textNowrap']//a").ToArray();
            HtmlNode[] country2 = document.DocumentNode.SelectNodes("//td[@class='colWalor textAlignLeft textNowrap']//a").ToArray();

            //pobranie tylko tych nazw co maja zakup i sprzedaz
            List<string> listOfName=validator.validateName(country, country2, name);

            //przygotowanie listy walut
            for (int i = 0,j=0,k=0; k < listOfName.Count; i += 4,j+=2,++k)
            {
                List<double> arguments = new List<double>();
                arguments.Add(validator.normalizeCurrency(value[j]));
                arguments.Add(validator.normalizeCurrency(change[i]));
                arguments.Add(validator.normalizeChangePercent(change[i+1]));//

                arguments.Add(validator.normalizeCurrency(value[j + 1]));
                arguments.Add(validator.normalizeCurrency(change[i+2]));
                arguments.Add(validator.normalizeChangePercent(change[i + 3]));//
                
                Currency currency = new Currency(listOfName[k], validator.normalizeCountry(country[k]),validator.normalizeSymbol(symbol[k]), arguments);
                listCurrency.addCurrency(currency);
             }

            HtmlNode time = document.DocumentNode.SelectNodes("//time[@class='time']").First();
            listCurrency.TimeOfUpdate = time.InnerText.ToString().Substring(32);
        }
    }
}
