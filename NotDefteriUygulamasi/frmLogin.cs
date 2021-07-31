using NotDefteriUygulamasi.Entities;
using NotDefteriUygulamasi.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotDefteriUygulamasi
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            adminManagement = new AdminManagement();
            userManagement = new UserManagement();
        }
 
        AdminManagement adminManagement;
        UserManagement userManagement;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool adminCheck = adminManagement.AdminLogin(txtUserName.Text, txtPassword.Text);
            if (adminCheck)
            {
                OpenForm(new frmAdmin());
            }
            else
            {
                try
                {
                    User user = userManagement.UserLogin(txtUserName.Text, txtPassword.Text);
                    OpenForm(new frmMain(user));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            ClearControl.Clear(this);
        }
        private void OpenForm(Form frm)
        {
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void lnkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenForm(new frmRegister());
        }    
    }
}
