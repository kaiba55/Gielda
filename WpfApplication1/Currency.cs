﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class Currency
    {
        private string name;
        private string country;
        private string symbol;
        private double purchaseValue;
        private double purchaseChange;
        private double purchaseChangePercent;
        private double saleValue;
        private double saleChange;
        private double saleChangePercent;

        public Currency(string name,string country, string symbol, List<double>arguments)
        {
            this.name = name;
            this.country = country;
            this.symbol = symbol;
            purchaseValue = arguments[0];
            purchaseChange= arguments[1];
            purchaseChangePercent= arguments[2];
            saleValue = arguments[3];
            saleChange = arguments[4];
            saleChangePercent = arguments[5];
        }
        public string Name
        {
            get { return name; }
        }
        public string Country
        {
            get { return country; }
        }
        public string Symbol
        {
            get { return symbol; }
        }
        public double PurchaseValue
        {
            get { return purchaseValue; }
        }
        private double PurchaseChange
        {
            get { return purchaseChange; }
        }
        private double SaleValue
        {
            get { return saleValue; }
        }
        private double SaleChange
        {
            get { return saleChange; }
        }
        private double SaleChangePercent
        {
            get { return saleChangePercent; }
        }
    }
}