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
            dbContext = NoteContext.GetInstance();
            adminManagement = new AdminManagement();
            userManagement = new UserManagement();
        }
        NoteContext dbContext;
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


        private void frmLogin_Load_1(object sender, EventArgs e)
        {
            if (dbContext.Users.All(x => x.UserName != "mertgogersin"))
            {
                User user = new User()
                {
                    Name = "Mert",
                    SurName = "Gogersin",
                    UserName = "mertgogersin",
                    Password = "123"
                };
                dbContext.Users.Add(user);
                dbContext.SaveChanges();
            }
        }
    }
}
