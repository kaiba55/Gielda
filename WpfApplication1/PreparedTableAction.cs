using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace WpfApplication1
{
    class PreparedTableAction
    {
        private NameOfColums columnsForActions;
        private NameOfColums nameOfVariables;
        public PreparedTableAction()
        {
            columnsForActions = new NameOfColums();
            columnsForActions.addName("Name");
            columnsForActions.addName("Value");
            columnsForActions.addName("Change");
            columnsForActions.addName("ChangePercent");
            columnsForActions.addName("NumberOfTransaction");
            columnsForActions.addName("Opening");
            columnsForActions.addName("Max");
            columnsForActions.addName("Min");
            columnsForActions.addName("MoneyTurnover");
            columnsForActions.addName("Time");

            nameOfVariables = new NameOfColums();
            nameOfVariables.addName("Nazwa");
            nameOfVariables.addName("Kurs");
            nameOfVariables.addName("Zmiana");
            nameOfVariables.addName("Zmiana procentowa");
            nameOfVariables.addName("Liczba transakcji");
            nameOfVariables.addName("Otwarcie");
            nameOfVariables.addName("Max");
            nameOfVariables.addName("Min");
            nameOfVariables.addName("Obrót");
            nameOfVariables.addName("Czas");
        }

        public void preparedTable(DataGrid grid, ListOfData list)
        {
            for (int i = 0; i <ColumnsForActions.NameOfColumsAction.Count; ++i)
            {
                DataGridTextColumn textcol = new DataGridTextColumn();
                textcol.Header = NameOfVariables.NameOfColumsAction[i];
                textcol.Binding = new Binding(ColumnsForActions.NameOfColumsAction[i]);
                grid.Columns.Add(textcol);
            }

            for(int i=0;i<list.ListData.Count;++i)
            {
                grid.Items.Add(list.ListData[i]);
            }
        }


        public NameOfColums ColumnsForActions
        {
            get { return columnsForActions; }
        }

        public NameOfColums NameOfVariables
        {
            get { return nameOfVariables; }
        }
    }
}
