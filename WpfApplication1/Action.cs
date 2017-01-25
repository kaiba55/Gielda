﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Windows.Controls;

namespace WpfApplication1
{
    //akcje stąd http://www.bankier.pl/gielda/notowania/akcje
    class Action
    {
        private string name;
        private double value;
        private double change;
        private double changePercent;
        private double opening;
        private double max;
        private double min;
        private double moneyTurnover;
        private string time;

        public Action(string name, List<double> listOfArguments, string time)
        {
            this.name = name;
            this.value = listOfArguments[0];
            this.change = listOfArguments[1];
            this.changePercent = listOfArguments[2];
            this.opening = listOfArguments[3];
            this.max = listOfArguments[4];
            this.min = listOfArguments[5];
            this.moneyTurnover = listOfArguments[6];
            this.time = time;
        }
    }
}
