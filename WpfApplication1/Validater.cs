using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace WpfApplication1
{
    class Validater
    {
        public string validateNameOfIndex(HtmlNode node)
        {
            return node.InnerHtml.ToString();
        }

        public double validateValue(HtmlNode node)
        {
            string temp = node.InnerHtml.ToString();
            temp = temp.Replace("&nbsp;", "");
            return Convert.ToDouble(temp);
        }

        public double validateChange(HtmlNode node)
        {
            return Convert.ToDouble(node.InnerHtml.ToString());
        }

        public double validateChangePercent(HtmlNode node)
        {
            string temp = node.InnerHtml.ToString();
            temp = temp.Remove(temp.Length - 1);
            return Convert.ToDouble(temp);
        }

        public double validateNumberofTransaction(HtmlNode node)
        {
            string temp = node.InnerHtml.ToString();
            temp = temp.Replace("&nbsp;", "");
            return Convert.ToDouble(temp);
        }

        public double validateMoneyTurnover(HtmlNode node)
        {
            string temp = node.InnerHtml.ToString();
            temp = temp.Replace("&nbsp;", "");
            return Convert.ToDouble(temp);
        }

        public double validateOpening(HtmlNode node)
        {
            string temp = node.InnerHtml.ToString();
            temp = temp.Replace("&nbsp;", "");
            return Convert.ToDouble(temp);
        }

        public double validateMax(HtmlNode node)
        {
            string temp = node.InnerHtml.ToString();
            temp = temp.Replace("&nbsp;", "");
            return Convert.ToDouble(temp);
        }

        public double validateMin(HtmlNode node)
        {
            string temp = node.InnerHtml.ToString();
            temp = temp.Replace("&nbsp;", "");
            return Convert.ToDouble(temp);
        }

        public string validateTime(HtmlNode node)
        {
            string temp = node.InnerHtml.ToString();
            temp = temp.Replace("&nbsp;", "");
            return temp;
        }
    }
}
