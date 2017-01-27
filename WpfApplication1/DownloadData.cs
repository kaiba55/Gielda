using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class DownloadData
    {
        protected ListOfData listData;
        protected DataValidater validator;
        protected DataFactory factory;

        public DownloadData()
        {
            validator = new DataValidater();
        }
        public ListOfData ListOfData
        {
            get { return listData; }
        }
    }
}
