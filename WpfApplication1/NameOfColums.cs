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
        private List<string> nameOfVariables;

        public NameOfColums()
        {
            nameOfColumsAction = new List<string>();
            nameOfVariables=new List< string > ();
        }

        public void addColumn(string name)
        {
            nameOfColumsAction.Add(name);
        }

        public void addVariables(string name)
        {
            nameOfVariables.Add(name);
        }

        public List<string> NameOfColumsAction
        {
            get { return nameOfColumsAction; }
        }

        public List<string> NameOfVariables
        {
            get { return nameOfVariables; }
        }
    }
}
