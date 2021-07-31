using NotDefteriUygulamasi.Entities;
using NotDefteriUygulamasi.Repositories;
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

namespace NotDefteriUygulamasi
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain(User _user)
        {
            InitializeComponent();           
            user = _user;       
            noteManagement = new NoteManagement();
            note = new Note();
        }     
        User user;
        Note note;      
        NoteManagement noteManagement;
        bool newNoteCheck;
        private void frmMain_Load(object sender, EventArgs e)
        {
            txtHeader.Visible = false;
            txtNote.Visible = false;
            FillList();
        }
        public void FillList()
        {            
            lbNoteHeaders.Items.Clear();            
            foreach (Note item in noteManagement.GetNotesByUserID(user.UserID))
            {
                lbNoteHeaders.Items.Add(item);//toString() override edip direkt classı attım.(dataSource ile de yapılabilir.)
            }
        }
        private void btnNewNote_Click(object sender, EventArgs e)
        {
            txtHeader.Visible = true;
            txtNote.Visible = true;
            ClearControl.Clear(this);
            newNoteCheck = true;
        }
        private void pbSaveNote_Click(object sender, EventArgs e)
        {
            try
            {
                if (newNoteCheck)
                {
                    noteManagement.AddNote(user, txtHeader.Text, txtNote.Text);
                    MessageBox.Show("Not eklenmiştir.");
                }
                else
                {
                    noteManagement.UpdateNote(note, txtHeader.Text, txtNote.Text);

                }
                FillList();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtHeader.Visible = false;
            txtNote.Visible = false;
            ClearControl.Clear(this);
        }
        private void lbNoteHeaders_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            note = (Note)lbNoteHeaders.SelectedItem; //listbox'a class attığım için SelectedItem ile çekebildim
            txtHeader.Visible = true;
            txtNote.Visible = true;
            newNoteCheck = false;
            txtHeader.Text = note.Header;
            txtNote.Text = note.Description;

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                noteManagement.DeleteNote(note.NoteID);
                txtHeader.Visible = false;
                txtNote.Visible = false;
                ClearControl.Clear(this);
                newNoteCheck = true;
                MessageBox.Show("Not başarıyla silinmiştir.");
                FillList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void lnkChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPassword frm = new frmPassword(user);
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
