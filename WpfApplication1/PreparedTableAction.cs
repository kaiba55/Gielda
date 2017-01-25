using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class PreparedTableAction
    {
        private NameOfColums columnsForActions;
        public void preparedNameOfColumnsForTableActions()
        {
            columnsForActions = new NameOfColums();
            columnsForActions.addName("Kurs odniesienia");
            columnsForActions.addName("Kurs otwarcia:");
            columnsForActions.addName("Max 1D:");
            columnsForActions.addName("Min 1D:");
            columnsForActions.addName("Wolumen obrotu:");
            columnsForActions.addName("Wartość obrotu:");
            columnsForActions.addName("Liczba transakcji:");
            columnsForActions.addName("Stopa zwrotu 1R:");
            columnsForActions.addName("Max 1R:");
            columnsForActions.addName("Min 1R:");
            columnsForActions.addName("System notowań:");
        }
    }
}
