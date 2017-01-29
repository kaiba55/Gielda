using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApplication1
{
    interface IPreparedTable
    {
        void preparedTable(DataGrid grid, ListOfData list);
        void preparedColumn();
    }
}
