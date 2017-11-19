using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_RoryStouder
{
    class DBUtilites
    {
        private StockDataSetTableAdapters.ProductsTableAdapter adapter =
            new StockDataSetTableAdapters.ProductsTableAdapter();

        public bool Update(int id, string name, bool status)
        {
            if (adapter.Update(name, status, id) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
