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
    public partial class frmPassword : Form
    {
        public frmPassword()
        {
            InitializeComponent();
        }
        public frmPassword( User _user)
        {
            InitializeComponent();
            user = _user;
            userManagement = new UserManagement();
        }
        User user;
        UserManagement userManagement;
      
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNewPassword.Text.Trim() == txtRewriteNewPassword.Text.Trim())
                {
                    userManagement.ChangePassword(user, txtNewPassword.Text);
                    MessageBox.Show("Şifreniz başarıyla değiştirildi.");
                }
                else
                {
                    MessageBox.Show("Şifreler uyuşmamaktadır.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
