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

        DBUtilitesProducts myDBUtilites = new DBUtilitesProducts();

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
            dgvProducts.DataSource = myDBUtilites.Items;
        }

        public void UpdateForm()
        {
            dgvProducts.DataSource = myDBUtilites.Items;

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

            try
            {
                // add the new product to the database
                adapter.Insert(code, name, status);
                lblStatus.Text = "Product added";
                
            }
            catch
            {
                lblStatus.Text = "Error adding new product";
            }
            

            // reading the data form the data base.
            dgvProducts.DataSource = myDBUtilites.Items;
            UpdateForm();
            txtProductCode.Text = string.Empty;
            txtProductName.Text = string.Empty;
        }

        public bool IfProductExists()
        {
            // need to add code to validate if product is already in the database.
            return true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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

            try
            {
                if (IfProductExists())
                {
                    // Update the product in the database
                    adapter.Update(name, status, code);
                    lblStatus.Text = "Product Updated";
                }
                else
                {
                    lblStatus.Text = "No product to update";
                }
            }
            catch
            {
                lblStatus.Text = "Error adding new product";
            }

            // reading the data form the data base.
            dgvProducts.DataSource = myDBUtilites.Items;
            UpdateForm();
            txtProductCode.Text = string.Empty;
            txtProductName.Text = string.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // HOUSEKEEPING
            errProviderProducts.Clear();
            lblStatus.Text = string.Empty;

            if (dgvProducts.SelectedRows.Count > 0)
            {
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

                DialogResult r =
                    MessageBox.Show("Deleting the selected product will permanently remove it. Do you want to continue?",
                    "Confirm Delete", MessageBoxButtons.YesNo);

                if (r == DialogResult.Yes)
                {
                    int selectedId = (int)dgvProducts.SelectedRows[0].Cells[0].Value;

                    if (myDBUtilites.Delete(int.Parse(txtProductCode.Text)))
                    {
                        dgvProducts.DataSource = myDBUtilites.Items;
                        formLoading = true;
                        UpdateForm();
                        lblStatus.Text = "Product deleted";
                    }
                    else
                    {
                        lblStatus.Text = "Error deleting this product";
                    }
                }
            }
            else
            {
                lblStatus.Text = "You must select a product";
            }
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

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

