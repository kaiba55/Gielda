using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace WpfApplication1
{
    class TableCurrency
    {
        private NameOfColums columnsForCurrency;
        public TableCurrency()
        {
            columnsForCurrency = new NameOfColums();
        }
        public void preparedTable(DataGrid grid, ListOfCurrency list)
        {
            preparedColumn();
            if (grid.Columns.Count == 0)
            {
                for (int i = 0; i < columnsForCurrency.NameOfColumsAction.Count; ++i)
                {
                    DataGridTextColumn textcol = new DataGridTextColumn();
                    textcol.Header = columnsForCurrency.NameOfColumsAction[i];
                    textcol.Binding = new Binding(columnsForCurrency.NameOfVariables[i]);
                    grid.Columns.Add(textcol);
                }
            }

           if (grid.Items.Count == 0)
           {
                for (int i = 0; i < list.ListCurrency.Count; ++i)
                {
                    grid.Items.Add(list.ListCurrency[i]);
                }
            }
        }

        public void preparedColumn()
        {
            columnsForCurrency.addVariables("Name");
            columnsForCurrency.addVariables("Country");
            columnsForCurrency.addVariables("Symbol");
            columnsForCurrency.addVariables("PurchaseValue");
            columnsForCurrency.addVariables("PurchaseChange");
            columnsForCurrency.addVariables("PurchaseChangePercent");
            columnsForCurrency.addVariables("SaleValue");
            columnsForCurrency.addVariables("SaleChange");
            columnsForCurrency.addVariables("SaleChangePercent");

            columnsForCurrency.addColumn("Nazwa");
            columnsForCurrency.addColumn("Kraj");
            columnsForCurrency.addColumn("Symbol");
            columnsForCurrency.addColumn("Zakup");
            columnsForCurrency.addColumn("Zmiana zakupu");
            columnsForCurrency.addColumn("Zmiana zakupu[%]");
            columnsForCurrency.addColumn("Sprzedaż");
            columnsForCurrency.addColumn("Zmiana sprzedaży");
            columnsForCurrency.addColumn("Zmiana sprzedaży[%]");
        }

        public NameOfColums ColumnsForCurrency
        {
            get { return columnsForCurrency; }
        }
    }
}
