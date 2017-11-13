using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_RoryStouder
{
    public partial class Login : Form
    {
        private StockDataSetTableAdapters.LoginTableAdapter loginAdapter =
            new StockDataSetTableAdapters.LoginTableAdapter();

        public Login()
        {
            InitializeComponent();
        }
        
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            //txtPassword.PasswordChar = radShowPassword.Checked ? '\0' : '*';
            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // TO-DO: Check Login username & Password
            //HOUSEKEEPING
            errProviderLogin.Clear();
            lblStatus.Text = string.Empty;

            // must validate the username cannot be blank and in email form, and the password must be an integer.
            string username = txtUsername.Text;
            int password = 0;

            bool IsValidEmail(string user)
            {
                try
                {
                    var address = new System.Net.Mail.MailAddress(user);
                    return address.Address == user;
                }
                catch
                {
                    errProviderLogin.SetError(txtUsername, "Invalid Username!");
                    return false;
                }
            }

            IsValidEmail(txtUsername.Text);

            if (!int.TryParse(txtPassword.Text, out password))
            {
                errProviderLogin.SetError(txtPassword, "You must enter a numeric value!");
                return;
            }
            else
            {
                password = int.Parse(txtPassword.Text);
            }


            if (loginAdapter.Search(loginAdapter.GetData(), username, password) > 0)
            {
                StockMain mainForm = new StockMain();
                mainForm.Show();
                this.Hide();
                this.AcceptButton = null;
                txtPassword.Clear();
                txtUsername.Clear();
            }
            else if (loginAdapter.SearchUsername(loginAdapter.GetData(), username) > 0) 
            {
                errProviderLogin.SetError(txtPassword, "invalid password");
            }
            else
            {
                lblStatus.Text = "Invalid credentials";
            }
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            txtPassword.Text = string.Empty;
            txtUsername.Text = string.Empty;
            chkShowPassword.Checked = false;
            txtUsername.Focus();
        }
    }
}
