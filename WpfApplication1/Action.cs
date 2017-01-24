using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Windows.Controls;

namespace WpfApplication1
{
    class Action
    {
        public Action(TextBox t,string url)
        { 
            //to bedzie konkretna akcja- chce kliknac w tabelce na akcje i przejsc do niej
            HtmlWeb web = new HtmlWeb();
            HtmlDocument document = web.Load(url);

            //te nazwy kolum też do innej klasy wywalić
            List<string> nameOfColum = new List<string>();
            nameOfColum.Add("Kurs odniesienia");
            nameOfColum.Add("Kurs otwarcia:");
            nameOfColum.Add("Max 1D:");
            nameOfColum.Add("Min 1D:");
            nameOfColum.Add("Wolumen obrotu:");
            nameOfColum.Add("Wartość obrotu:");
            nameOfColum.Add("Liczba transakcji:");
            nameOfColum.Add("Stopa zwrotu 1R:");
            nameOfColum.Add("Max 1R:");
            nameOfColum.Add("Min 1R:");
            nameOfColum.Add("System notowań:");
            
            //nazwa akcji
            HtmlNode timeOfUpdate = document.DocumentNode.SelectNodes("//h1[@class='small-title']").First();
           // t.Text = timeOfUpdate.InnerHtml;

            //kurs odniesienia
            HtmlNode kursodniesienia = document.DocumentNode.SelectNodes("//td[@id='referencePrice']").First();
            //t.Text = kursodniesienia.InnerHtml;

            //kurs otwarcia
            HtmlNode []kursotwarcia = document.DocumentNode.SelectNodes("//tr[@class='startingData']//td").ToArray();
            //t.Text = kursotwarcia[1].InnerHtml;

            //Max 1D:
            t.Text = kursotwarcia[5].InnerHtml;

            //Min 1D:
            t.Text = kursotwarcia[7].InnerHtml;

            //Wolumen obrotu:
            string temp = kursotwarcia[9].InnerHtml.ToString();
            temp = temp.Replace("&nbsp;", "");
            t.Text = temp + "\n";

            //Wartość obrotu:
            temp = kursotwarcia[11].InnerHtml.ToString();
            temp = temp.Replace("&nbsp;", "");
            t.Text = temp + "\n";

            //Liczba transakcji
            t.Text = kursotwarcia[13].InnerHtml;

            //Stopa zwrotu 1R:
            t.Text = kursotwarcia[15].InnerHtml;

            //Max 1R:
             HtmlNode[] time = document.DocumentNode.SelectNodes("//time[@class='time']").ToArray();
             HtmlNode[] max1R = document.DocumentNode.SelectNodes("//table[@class='summaryTable']//tr[@class='startingData']").ToArray();
            string temp2 = kursotwarcia[17].InnerHtml.ToString();
            string[] words = temp2.Split(' ');
            string temp3 = words[44] + " zł" + " " + time[1].InnerHtml.ToString();
            /*t.Text = temp3;*/




            //Min1R
           temp2 = kursotwarcia[19].InnerHtml.ToString();
            words = temp2.Split(' ');
            temp3 = words[44] + " zł" + " " + time[2].InnerHtml.ToString();
            t.Text = temp3;

            //system notowan
             t.Text = kursotwarcia[21].InnerHtml;
        }
    }
}
