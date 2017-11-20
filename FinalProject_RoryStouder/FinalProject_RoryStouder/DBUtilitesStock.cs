using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_RoryStouder
{
    class DBUtilitesStock
    {
        private StockDataSetTableAdapters.StockTableAdapter adapter = 
            new StockDataSetTableAdapters.StockTableAdapter();

        public bool AddStock(int id, DateTime date, int quantity)
        {
            bool result = true;

            try
            {
                int test = adapter.AddStock(id, date, quantity);
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }

        public bool ShipStock(int id)
        {
            bool result = true;

            try
            {
                int test = adapter.DeleteStock(id);
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }
    }

    
}
