using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_RoryStouder
{
    class DBUtilitesProducts
    {
        private StockDataSetTableAdapters.ProductsTableAdapter adapter =
            new StockDataSetTableAdapters.ProductsTableAdapter();

        public DataTable Items
        {
            get
            {
                return adapter.GetData();
            }
        }

        public bool Insert(int id, string name, bool status)
        {
            bool result = true;
            try
            {
                adapter.Insert(id, name, status);
            }
            catch (Exception ex)
            {
                result = false;
            }

            return result;
            
        }

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

        public bool Delete(int id)
        {
            bool result = true;
            
            if (adapter.Delete(id) > 0)
            {
                result = true;
            }
            return result;
        }

        
    }
}
