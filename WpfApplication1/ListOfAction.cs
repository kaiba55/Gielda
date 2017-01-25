using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class ListOfAction
    {
        List<Action> listOfStockAction;

        public ListOfAction()
        {
            listOfStockAction = new List<Action>();
        }
        public void addAction(Action action)
        {
            listOfStockAction.Add(action);
        }
    }
}
