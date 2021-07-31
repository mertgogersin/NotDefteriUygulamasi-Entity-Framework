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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
            dbContext = NoteContext.GetInstance();
            userManagement = new UserManagement();
        }
       
        NoteContext dbContext;
        UserManagement userManagement;
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text.Trim() == txtPasswordAgain.Text.Trim())
                {
                    userManagement.UserSignUp(txtName.Text, txtSurName.Text, txtUserName.Text, txtPassword.Text);
                    MessageBox.Show("Kaydınız başarıyla oluşturulmuştur.");
                    this.Close();
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
