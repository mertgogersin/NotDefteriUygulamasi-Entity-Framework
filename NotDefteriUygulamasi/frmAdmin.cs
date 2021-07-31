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
    public partial class frmAdmin : Form
    {
     
        public frmAdmin()
        {
            InitializeComponent();
            users = new List<User>();
            adminManagement = new AdminManagement();
        }
        List<User> users;
        AdminManagement adminManagement;
        private void frmAdmin_Load(object sender, EventArgs e)
        {
            FillList();
        }
        public void FillList()
        {
            users.Clear();
            lstPassiveUsers.Items.Clear();
            users = adminManagement.GetUnVerifiedUsers();
            int i = 0;
            foreach (User item in users)
            {
                lstPassiveUsers.Items.Add(item.Name);
                lstPassiveUsers.Items[i].SubItems.Add(item.SurName);
                lstPassiveUsers.Items[i].SubItems.Add(item.UserName);
                lstPassiveUsers.Items[i].SubItems.Add("Pasif");
                lstPassiveUsers.Items[i].Tag = item;
                i++;
            }
        }

        private void lstPassiveUsers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            User user = (User)lstPassiveUsers.SelectedItems[0].Tag;
            DialogResult dr = MessageBox.Show("Bu kullanıcıyı onaylıyor musunuz?","Onay",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
            if(dr==DialogResult.Yes)
            {
                adminManagement.VerifyUser(user.UserID);
            }
            else if(dr==DialogResult.No)
            {
                adminManagement.DeleteNonVerifiedUser(user.UserID);
            }
            FillList();
        }

       
    }
}
