using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace WpfApplication1
{
    class TableAction: IPreparedTable
    {
        private NameOfColums columnsForActions;
        public TableAction()
        {
            columnsForActions = new NameOfColums();
        }

        public void preparedTable(DataGrid grid, ListOfData list)
        {
            preparedColumn();
            if (grid.Columns.Count == 0)
            {
                for (int i = 0; i < ColumnsForActions.NameOfColumsAction.Count; ++i)
                {
                    DataGridTextColumn textcol = new DataGridTextColumn();
                    textcol.Header = columnsForActions.NameOfColumsAction[i];
                    textcol.Binding = new Binding(ColumnsForActions.NameOfVariables[i]);
                    grid.Columns.Add(textcol);
                }
            }

            if (grid.Items.Count == 0)
            {
                for (int i = 0; i < list.ListData.Count; ++i)
                {
                    grid.Items.Add(list.ListData[i]);
                }
            }
        }

        public void preparedColumn()
        {
            columnsForActions.addVariables("Name");
            columnsForActions.addVariables("Value");
            columnsForActions.addVariables("Change");
            columnsForActions.addVariables("ChangePercent");
            columnsForActions.addVariables("NumberOfTransaction");
            columnsForActions.addVariables("Opening");
            columnsForActions.addVariables("Max");
            columnsForActions.addVariables("Min");
            columnsForActions.addVariables("MoneyTurnover");
            columnsForActions.addVariables("Time");

            columnsForActions.addColumn("Nazwa");
            columnsForActions.addColumn("Kurs");
            columnsForActions.addColumn("Zmiana");
            columnsForActions.addColumn("Zmiana procentowa");
            columnsForActions.addColumn("Liczba transakcji");
            columnsForActions.addColumn("Otwarcie");
            columnsForActions.addColumn("Max");
            columnsForActions.addColumn("Min");
            columnsForActions.addColumn("Obrót");
            columnsForActions.addColumn("Czas");
        }

        public NameOfColums ColumnsForActions
        {
            get { return columnsForActions; }
        }
    }
}
