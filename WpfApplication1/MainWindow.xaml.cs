using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<IPreparedTable> table;
        private List<ListOfData> list;
        private List<IDownloadable> downloader;
        private List<CalculationStatisticsForData> calc;

        //do pobierania walut
        TableCurrency tableCurrency;
        ListOfCurrency listCurrency;
        DownloadCurrency downCurrency;
        CalculationStatisticsForCurrency calcCurrency;

        private void CenterWindowOnScreen()
        {
            double screenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
            double screenHeight = System.Windows.SystemParameters.PrimaryScreenHeight;
            double windowWidth = this.Width;
            double windowHeight = this.Height;
            this.Left = (screenWidth / 2) - (windowWidth / 2);
            this.Top = (screenHeight / 2) - (windowHeight / 2);
        }

        private void prepareCurrency()
        {
            label70.Content = listCurrency.TimeOfUpdate;
            tableCurrency.preparedTable(dataGrid4, listCurrency);
            preparedStatisticForCurrency();
        }

        public void preparedData()
        {
            list = new List<ListOfData>();
            list.Add(new ListOfAction());
            list.Add(new ListOfStockIndex());
            list.Add(new ListOfDebentures());
            calc = new List<CalculationStatisticsForData>();

            calc.Add(new CalculationStatisticsForAction());
            calc.Add(new CalculationStatisticsForStockIndex());
            calc.Add(new CalculationStatisticsForDebentures());

            table =new List<IPreparedTable>();
            table.Add(new TableAction());
            table.Add(new TableStockIndex());
            table.Add(new TableDebentures());

            downloader = new List<IDownloadable>();
            downloader.Add(new DownloadAction());
            downloader.Add(new DownloadStockIndexes());
            downloader.Add(new DownloadDebentures());
            downloader[0].download(list[0]);
            downloader[1].download(list[1]);
            downloader[2].download(list[2]);

            //przygotowanie walut
            tableCurrency = new TableCurrency();
            listCurrency=new ListOfCurrency();
            downCurrency = new DownloadCurrency();
            calcCurrency = new CalculationStatisticsForCurrency();
            downCurrency.download(listCurrency);   
        }

        void preparedStatisticForAction()
        {
            label11.Content = calc[0].maxValue(list[0].ListData);
            label13.Content = calc[0].minValue(list[0].ListData);
            label23.Content= calc[0].maxChange(list[0].ListData);
            label25.Content = calc[0].minChange(list[0].ListData);
            label27.Content = calc[0].maxChangePercent(list[0].ListData);
            label29.Content = calc[0].minChangePercent(list[0].ListData);
            label31.Content = calc[0].maxMoneyTurnover(list[0].ListData);
            label33.Content = calc[0].minMoneyTurnover(list[0].ListData);
            label35.Content=calc[0].maxTransaction(list[0].ListData);

            label37.Content = calc[0].maxOpening(list[0].ListData);
            label39.Content = calc[0].minOpening(list[0].ListData);
        }

        void preparedStatisticForCurrency()
        {
            label72.Content = calcCurrency.maxPurchaseValue(listCurrency.ListCurrency);
            label74.Content = calcCurrency.minPurchaseValue(listCurrency.ListCurrency);
            label76.Content = calcCurrency.maxPurchaseChange(listCurrency.ListCurrency);
            label78.Content = calcCurrency.minPurchaseChange(listCurrency.ListCurrency);
            label80.Content = calcCurrency.maxPurchaseChangePercent(listCurrency.ListCurrency);
            label82.Content = calcCurrency.minPurchaseChangePercent(listCurrency.ListCurrency);
            label84.Content = calcCurrency.maxSaleValue(listCurrency.ListCurrency);
            label86.Content = calcCurrency.minSaleValue(listCurrency.ListCurrency);
            label88.Content = calcCurrency.maxSaleChange(listCurrency.ListCurrency);
            label90.Content = calcCurrency.minSaleChange(listCurrency.ListCurrency);
            label92.Content = calcCurrency.maxSaleChangePercent(listCurrency.ListCurrency);
            label94.Content = calcCurrency.minSaleChangePercent(listCurrency.ListCurrency);
        }

        void preparedStatisticForStockIndexes()
        {
            label15.Content = calc[1].maxValue(list[1].ListData);
            label17.Content = calc[1].minValue(list[1].ListData);
            label42.Content = calc[1].maxChange(list[1].ListData);
            label44.Content = calc[1].minChange(list[1].ListData);
            label46.Content = calc[1].maxChangePercent(list[1].ListData);
            label48.Content = calc[1].minChangePercent(list[1].ListData);          
            label50.Content = calc[1].maxOpening(list[1].ListData);
            label52.Content = calc[1].minOpening(list[1].ListData);
            label54.Content = calc[1].maxMoneyTurnover(list[1].ListData);
            label56.Content = calc[1].minMoneyTurnover(list[1].ListData);

        }

        void preparedStatisticForDebentures()
        {
            label19.Content = calc[2].maxValue(list[2].ListData);
            label21.Content = calc[2].minValue(list[2].ListData);
            label58.Content = calc[2].maxChange(list[2].ListData);
            label60.Content = calc[2].minChange(list[2].ListData);
            label62.Content = calc[2].maxChangePercent(list[2].ListData);
            label64.Content = calc[2].minChangePercent(list[2].ListData);
            label66.Content = calc[2].maxOpening(list[2].ListData);
            label68.Content = calc[2].minOpening(list[2].ListData);
        }

        public void prepareAction()
        {    
            table[0].preparedTable(dataGrid, list[0]);
            label7.Content = list[0].TimeOfUpdate;
            preparedStatisticForAction();

            /*SaveDataToDatabase saveDb = new SaveActionToDatabase();
            saveDb.WhatSave = "Action";
            saveDb.save(list[0]);

            ReadDataFromDatabase readDb = new ReadActionFromDatabase();
            readDb.WhatRead = "Action2017-01-31 13:02";
            readDb.read(list[0]);
            int a = 7;*/
        }

        public void prepareStockIndexes()
        {
            table[1].preparedTable(dataGrid2, list[1]);
            label8.Content = list[1].TimeOfUpdate;
            preparedStatisticForStockIndexes();
        }

        public void prepareDebentures()
        {
            table[2].preparedTable(dataGrid3, list[2]);
            label9.Content = list[2].TimeOfUpdate;
            preparedStatisticForDebentures();
        }

        public MainWindow()
        {
            preparedData();
            InitializeComponent();
            CenterWindowOnScreen();
            preparedCombobox();

        }

        private void preparedCombobox()
        {
            comboBox2.Items.Add("Kursu sprzedaży");
            comboBox2.Items.Add("Kursu zakupu");
            List<string> list = listCurrency.preparedListSymbol();
            comboBox.Items.Add("1 PLN");
            comboBox1.Items.Add("1 PLN");
            foreach (var elem in list)
            {
                comboBox.Items.Add(elem);
                comboBox1.Items.Add(elem);
            }

        }
        private void OnTab1Selected(object sender, RoutedEventArgs e)
        {
            var tab = sender as TabItem;
            if (tab != null)
            {
                prepareAction();
            }
        }

        private void OnTab2Selected(object sender, RoutedEventArgs e)
        {
            var tab = sender as TabItem;
            if (tab != null)
            {
                prepareStockIndexes();
            }
        }

        private void OnTab3Selected(object sender, RoutedEventArgs e)
        {
            var tab = sender as TabItem;
            if (tab != null)
            {
                prepareDebentures();
            }
        }

        private void OnTab4Selected(object sender, RoutedEventArgs e)
        {
            var tab = sender as TabItem;
            if (tab != null)
            {
                prepareCurrency();        
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            downloader[0].download(list[0]);
            preparedStatisticForAction();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            downloader[1].download(list[1]);
            preparedStatisticForStockIndexes();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            downloader[2].download(list[2]);          
            prepareDebentures();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            downCurrency.download(listCurrency);
            prepareCurrency();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            CurrencyConverter converter = new CurrencyConverter();
            double value = 1 ;
            try
            {
                value = Convert.ToDouble(textBox.Text);
                string selected = comboBox.SelectionBoxItem.ToString(); //z
                string selected2 = comboBox1.SelectionBoxItem.ToString();//
                string selected3 = comboBox2.SelectionBoxItem.ToString();//kurs

                textBox1.Text = converter.convert(listCurrency, selected, selected2, selected3, value).ToString();
            }
            catch(Exception)
            {
                textBox.Text = "Wpisz liczbę";
            }
            
        }
    }
}
