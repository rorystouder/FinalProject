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
    public partial class frmStock : Form
    {
        public frmStock()
        {
            InitializeComponent();
        }

        private void frmStock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockDataSet.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.stockDataSet.Stock);

        }
    }
}
