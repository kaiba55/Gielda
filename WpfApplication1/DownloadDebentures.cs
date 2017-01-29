﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace WpfApplication1
{
    class DownloadDebentures : IDownloadable
    {
        private DataValidater validator;
        private DataFactory factory;
        public DownloadDebentures()
        {
            validator = new DataValidater();
            factory = new DebenturesFactory();
        }
        public void download(ListOfData list)
        {
            string url = "http://www.bankier.pl/gielda/notowania/obligacje";
            HtmlWeb web = new HtmlWeb();
            HtmlDocument document = web.Load(url);

            //przygotowanie danych dotyczacych akcji
            HtmlNode[] nameOfIndex = document.DocumentNode.SelectNodes("//td[@class='colWalor textNowrap']").ToArray();//inkrementowany co 2
            HtmlNode[] value = document.DocumentNode.SelectNodes("//td[@class='colKurs change  up' or @class='colKurs change  down' or @class='colKurs change ']").ToArray();
            HtmlNode[] change = document.DocumentNode.SelectNodes("//td[@class='colZmiana change  up' or @class='colZmiana change  down' or @class='colZmiana change ']").ToArray();
            HtmlNode[] changePercent = document.DocumentNode.SelectNodes("//td[@class='colZmianaProcentowa change  up' or @class='colZmianaProcentowa change  down' or @class='colZmianaProcentowa change ']").ToArray();
            HtmlNode[] opening = document.DocumentNode.SelectNodes("//td[@class='colOtwarcie']").ToArray();
            HtmlNode[] max = document.DocumentNode.SelectNodes("//td[@class='calMaxi']").ToArray();
            HtmlNode[] min = document.DocumentNode.SelectNodes("//td[@class='calMini']").ToArray();
            HtmlNode[] time = document.DocumentNode.SelectNodes("//td[@class='colAktualizacja']").ToArray();


            //sformatowanie danych i dodanie na liste akcji
            for (int i = 0, j = 0; j < nameOfIndex.Length; ++i, j += 2)
            {
                List<double> arguments = new List<double>();
                arguments.Add(validator.validateValue(value[i]));
                arguments.Add(validator.validateChange(change[i]));
                arguments.Add(validator.validateChangePercent(changePercent[i]));
                arguments.Add(validator.validateOpening(opening[i]));
                arguments.Add(validator.validateMax(max[i]));
                arguments.Add(validator.validateMin(min[i]));
                list.addData(factory.produce(validator.validateNameOfIndex(nameOfIndex[j]), arguments, validator.validateTime(time[i])));
            }

            HtmlNode timeOfUpdate = document.DocumentNode.SelectNodes("//time[@class='time']").First();
        }
    }
}
