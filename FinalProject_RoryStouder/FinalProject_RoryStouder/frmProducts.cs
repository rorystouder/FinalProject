using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_RoryStouder
{
    public partial class frmProducts : Form
    {
        private StockDataSetTableAdapters.ProductsTableAdapter adapter =
            new StockDataSetTableAdapters.ProductsTableAdapter();

        private bool formLoading = true;

        public frmProducts()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.stockDataSet.Products);
            cboStatus.SelectedIndex = 0;
            txtProductCode.Focus();
            dgvProducts.DataSource = adapter.GetData();
        }

        public void UpdateForm()
        {
            dgvProducts.DataSource = adapter.GetData();

            formLoading = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // HOUSEKEEPING
            errProviderProducts.Clear();
            lblStatus.Text = string.Empty;

            int code = 0;
            string name = txtProductName.Text;
            bool status = false;

            // validate inputs
            if (txtProductCode.Text == "")
            {
                errProviderProducts.SetError(txtProductCode, "Product code must not be blank!");
                return;
            }

            if (!int.TryParse(txtProductCode.Text, out code))
            {
                errProviderProducts.SetError(txtProductCode, "Product code should be a numeric value!");
                return;
            }
            else
            {
                code = int.Parse(txtProductCode.Text);
            }

            if (txtProductName.Text == "")
            {
                errProviderProducts.SetError(txtProductName, "Product name must not be blank!");
                return;
            }

            if (cboStatus.SelectedIndex == 0)
            {
                status = true;
            }
            else
            {
                status = false;
            }

            if (IfProductExists())
            {
                Update();
            }
            else
            {
                // add the new product to the database
                try
                {
                    adapter.Insert(code, name, status);
                    lblStatus.Text = "Product added";
                }
                catch
                {
                    lblStatus.Text = "Error adding new product";
                }
            }

            // reading the data form the data base.
            dgvProducts.DataSource = adapter.GetData();
        }

        private bool IfProductExists()
        {
            return true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //// HOUSEKEEPING
            //lblStatus.Text = "";

            //if (dgvProducts.SelectedRows.Count > 0)
            //{
            //    DialogResult r =
            //        MessageBox.Show("Deleting the selected employee will permanently remove. Do you want to continue?",
            //        "Confirm Delete", MessageBoxButtons.YesNo);

            //    if (r == DialogResult.Yes)
            //    {
            //        string selectedId = dgvProducts.SelectedRows[0].Cells[0].Value.ToString();

            //        if (adapter.Delete(selectedId))
            //        {
            //            dgvProducts.DataSource = adapter.GetData();
            //            formLoading = true;
            //            UpdateForm();
            //            lblStatus.Text = "Employee deleted";
            //        }
            //        else
            //        {
            //            lblStatus.Text = "Error deleting this employee";
            //        }
            //    }
            //}
        }

        private void dgvProducts_MouseDoubleClick(object sender, MouseEventArgs e)
            {
                bool status = true;
                txtProductCode.Text = dgvProducts.SelectedRows[0].Cells[0].Value.ToString();
                txtProductName.Text = dgvProducts.SelectedRows[0].Cells[1].Value.ToString();
                if (dgvProducts.SelectedRows[0].Cells[2].Selected == true)
                {
                    cboStatus.SelectedIndex = 0;
                    status = true;
                }
                else
                {
                    cboStatus.SelectedIndex = 1;
                    status = false;
                }

            }
        }
    }

