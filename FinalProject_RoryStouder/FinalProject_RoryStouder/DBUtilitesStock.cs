using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_RoryStouder
{
    class DBUtilitesStock
    {
        private StockDataSetTableAdapters.StockTableAdapter adapter = 
            new StockDataSetTableAdapters.StockTableAdapter();

        private StockDataSetTableAdapters.ProductsTableAdapter productAdapter =
            new StockDataSetTableAdapters.ProductsTableAdapter();

        public DataTable Items
        {
            get
            {
                return adapter.GetData();
            }
        }


        public bool AddStock(int id, DateTime date, int quantity, bool status)
        {
            bool result = true;

            try
            {
                int test = adapter.AddStock(id, date, quantity);
                int update = productAdapter.UpdateQuantity(status, quantity, id);
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }

        public bool ShipStock(int id, DateTime date, int quantity, bool status)
        {
            bool result = true;

            try
            {
                int test = adapter.AddStock(id, date, quantity);
                int update = productAdapter.UpdateQuantity(status, quantity, id);

                DataTable product = productAdapter.GetProductByCode(id);
                if ((int)product.Rows[0][0] == 0)
                {
                    int updateStatus = productAdapter.UpdateQuantity(false, 0, id);
                }
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }

        

        public DataTable GetByCode(int code)
        {
            DataTable table = adapter.GetData();
            table.DefaultView.RowFilter = "ProductCode = " + code;
            return table;
        }

        public StockDataSet.StockRow FindByCode(int code)
        {
            StockDataSet.StockDataTable table;
            table = adapter.GetData();
            return table.FindByStockID(code);
        }
    }

    
}
