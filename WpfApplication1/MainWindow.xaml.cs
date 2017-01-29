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
        private void CenterWindowOnScreen()
        {
            double screenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
            double screenHeight = System.Windows.SystemParameters.PrimaryScreenHeight;
            double windowWidth = this.Width;
            double windowHeight = this.Height;
            this.Left = (screenWidth / 2) - (windowWidth / 2);
            this.Top = (screenHeight / 2) - (windowHeight / 2);
        }

        public void preparedData()
        {
            list = new List<ListOfData>();
            list.Add(new ListOfAction());
            list.Add(new ListOfStockIndex());
            list.Add(new ListOfDebentures());

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
        }

        public MainWindow()
        {
            preparedData();
            InitializeComponent();
            CenterWindowOnScreen();         
        }
        private void OnTab1Selected(object sender, RoutedEventArgs e)
        {
            var tab = sender as TabItem;
            if (tab != null)
            {
                table[0].preparedTable(dataGrid, list[0]);
            }
        }

        private void OnTab2Selected(object sender, RoutedEventArgs e)
        {
            var tab = sender as TabItem;
            if (tab != null)
            {
                table[1].preparedTable(dataGrid2, list[1]);
            }
        }

        private void OnTab3Selected(object sender, RoutedEventArgs e)
        {
            var tab = sender as TabItem;
            if (tab != null)
            {
                table[2].preparedTable(dataGrid3, list[2]);
            }
        }

    }
}
