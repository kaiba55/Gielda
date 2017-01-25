using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class PreparedTableStockIndexes
    {
        private NameOfColums columnsForStockIndexes;

        public void preparedNameOfColumnsForTableStockIndexes()
        {
            columnsForStockIndexes = new NameOfColums();
            columnsForStockIndexes.addName("Kurs odniesienia");
            columnsForStockIndexes.addName("Kurs otwarcia:");
            columnsForStockIndexes.addName("Max 1D:");
            columnsForStockIndexes.addName("Min 1D:");
            columnsForStockIndexes.addName("Wolumen obrotu:");
            columnsForStockIndexes.addName("Wartość obrotu:");
            columnsForStockIndexes.addName("Liczba transakcji:");
            columnsForStockIndexes.addName("Stopa zwrotu 1R:");
            columnsForStockIndexes.addName("Max 1R:");
            columnsForStockIndexes.addName("Min 1R:");
            columnsForStockIndexes.addName("System notowań:");
        }
    }
}
