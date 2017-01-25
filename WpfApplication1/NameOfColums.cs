using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class NameOfColums
    {
        private List<string> nameOfColumsAction;

        public NameOfColums()
        {
            nameOfColumsAction = new List<string>();
        }

        public void addName(string name)
        {
            nameOfColumsAction.Add(name);
        }
    }
}
