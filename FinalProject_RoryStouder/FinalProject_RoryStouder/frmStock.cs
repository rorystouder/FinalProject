using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace FinalProject_RoryStouder
{
    public partial class frmStock : Form
    {
        private StockDataSetTableAdapters.StockTableAdapter adapter = 
            new StockDataSetTableAdapters.StockTableAdapter();

        private StockDataSetTableAdapters.ProductsTableAdapter productAdapter =
            new StockDataSetTableAdapters.ProductsTableAdapter();

        DBUtilitesStock myDBUtilitesStock = new DBUtilitesStock();

        //private StockDataSet stockDataSet;

        public frmStock()
        {
            InitializeComponent();
        }

        private void frmStock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.stockDataSet.Products);
            // TODO: This line of code loads data into the 'stockDataSet.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.stockDataSet.Stock);
            this.productAdapter.Fill(this.stockDataSet.Products);

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProducts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            bool status = true;
            
            if (dgvProducts.SelectedRows[0].Cells[2].Selected == true)
            {
                DateTime dt = DateTime.ParseExact(dgvProducts.CurrentCell.Value.ToString(), "MM/dd/yyyy", CultureInfo.CurrentCulture);
                dtpCalendar.Value = dt;
                status = true;
            }
            txtQuanity.Text = dgvProducts.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void cboProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnShip_Click(object sender, EventArgs e)
        {
            // HOUSEKEEPING
            errProviderStock.Clear();

            if (txtQuanity.Text == "")
            {
                errProviderStock.SetError(txtQuanity, "Must input a quantity to ship!");
                return;
            }

            if(int.Parse(txtQuanity.Text) > 0)
            {
                errProviderStock.SetError(txtQuanity, "you must use a negative number.");
                return;
            }

            int selectedProductCode = (int)cboProducts.SelectedValue;
            //int productQuantity = int.Parse(txtQuanity.Text);
            //DateTime date = dtpCalendar.Value.Date;

            myDBUtilitesStock.ShipStock(selectedProductCode);
            
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            int selectedProductCode = (int)cboProducts.SelectedValue;
            int productQuantity = int.Parse(txtQuanity.Text);
            DateTime date = dtpCalendar.Value.Date;

            myDBUtilitesStock.AddStock(selectedProductCode, date, productQuantity);
            this.productsTableAdapter.Fill(this.stockDataSet.Products);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int code = (int)cboProducts.SelectedValue;

            dgvProducts.DataSource = myDBUtilitesStock.GetByCode(code);
        }
    }
}
