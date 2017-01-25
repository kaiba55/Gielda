using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace WpfApplication1
{
    class DownloadStockIndexes
    {
        private ListOfStockIndex listOftockIndexes;

        public DownloadStockIndexes()
        {
            listOftockIndexes = new ListOfStockIndex();
        }

        public string normalizeNameOfIndex(HtmlNode node)
        {
            return node.InnerHtml.ToString();
        }

        public double normalizeValue(HtmlNode node)
        {
            string temp = node.InnerHtml.ToString();
            temp = temp.Replace("&nbsp;", "");
            return Convert.ToDouble(temp);
        }

        public double normalizeChange(HtmlNode node)
        {
            return Convert.ToDouble(node.InnerHtml.ToString());
        }

        public double normalizeChangePercent(HtmlNode node)
        {
            string temp = node.InnerHtml.ToString();
            temp = temp.Remove(temp.Length - 1);
            return Convert.ToDouble(temp);
        }

        public double normalizeNumberofTransaction(HtmlNode node)
        {
            string temp = node.InnerHtml.ToString();
            temp = temp.Replace("&nbsp;", "");
            return Convert.ToDouble(temp);
        }

        public double normalizeMoneyTurnover(HtmlNode node)
        {
            string temp = node.InnerHtml.ToString();
            temp = temp.Replace("&nbsp;", "");
            return Convert.ToDouble(temp);
        }

        public double normalizeOpening(HtmlNode node)
        {
            string temp = node.InnerHtml.ToString();
            temp = temp.Replace("&nbsp;", "");
            return Convert.ToDouble(temp);
        }

        public double normalizeMax(HtmlNode node)
        {
            string temp = node.InnerHtml.ToString();
            temp = temp.Replace("&nbsp;", "");
            return Convert.ToDouble(temp);
        }

        public double normalizeMin(HtmlNode node)
        {
            string temp = node.InnerHtml.ToString();
            temp = temp.Replace("&nbsp;", "");
            return Convert.ToDouble(temp);
        }

        public string normalizeTime(HtmlNode node)
        {
            string temp = node.InnerHtml.ToString();
            temp = temp.Replace("&nbsp;", "");
            return temp;
        }


        public void download()
        {
            string url = "http://www.bankier.pl/gielda/notowania/akcje";
            HtmlWeb web = new HtmlWeb();
            HtmlDocument document = web.Load(url);

            //przygotowanie danych dotyczacych akcji
            HtmlNode[] nameOfIndex = document.DocumentNode.SelectNodes("//td[@class='colWalor textNowrap']//a").ToArray();//inkrementowany co 2
            HtmlNode[] value = document.DocumentNode.SelectNodes("//td[@class='colKurs change  up']").ToArray();
            HtmlNode[] change = document.DocumentNode.SelectNodes("//td[@class='colZmiana change  up']").ToArray();
            HtmlNode[] changePercent = document.DocumentNode.SelectNodes("//td[@class='colZmianaProcentowa change  up']").ToArray();
            HtmlNode[] numberOfTransaction = document.DocumentNode.SelectNodes("//td[@class='colLiczbaTransakcji']").ToArray();
            HtmlNode[] moneyTurnover = document.DocumentNode.SelectNodes("//td[@class='colObrot']").ToArray();
            HtmlNode[] opening = document.DocumentNode.SelectNodes("//td[@class='colOtwarcie']").ToArray();
            HtmlNode[] max = document.DocumentNode.SelectNodes("//td[@class='calMaxi']").ToArray();
            HtmlNode[] min = document.DocumentNode.SelectNodes("//td[@class='calMini']").ToArray();
            HtmlNode[] time = document.DocumentNode.SelectNodes("//td[@class='colAktualizacja']").ToArray();


            //sformatowanie danych i dodanie na liste indeksow
            for (int i = 0, j = 0; i < value.Length; ++i, j += 4)
            {
                List<double> arguments = new List<double>();
                arguments.Add(normalizeValue(value[i]));
                arguments.Add(normalizeChange(change[i]));
                arguments.Add(normalizeChangePercent(changePercent[i]));
                arguments.Add(normalizeNumberofTransaction(numberOfTransaction[i]));
                arguments.Add(normalizeMoneyTurnover(moneyTurnover[i]));
                arguments.Add(normalizeOpening(opening[i]));
                arguments.Add(normalizeMax(max[i]));
                arguments.Add(normalizeMax(min[i]));
                StockIndex temp = new StockIndex(normalizeNameOfIndex(nameOfIndex[j]), arguments, normalizeTime(time[i]));
                listOftockIndexes.addStockIndex(temp);
            }

            HtmlNode timeOfUpdate = document.DocumentNode.SelectNodes("//time[@class='time']").First();

        }

    }
}