
namespace NotDefteriUygulamasi
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbNoteHeaders = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNewNote = new System.Windows.Forms.Button();
            this.lnkChangePassword = new System.Windows.Forms.LinkLabel();
            this.txtHeader = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.pbSaveNote = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSaveNote)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNoteHeaders
            // 
            this.lbNoteHeaders.FormattingEnabled = true;
            this.lbNoteHeaders.ItemHeight = 20;
            this.lbNoteHeaders.Location = new System.Drawing.Point(18, 18);
            this.lbNoteHeaders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbNoteHeaders.Name = "lbNoteHeaders";
            this.lbNoteHeaders.Size = new System.Drawing.Size(173, 384);
            this.lbNoteHeaders.TabIndex = 0;
            this.lbNoteHeaders.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbNoteHeaders_MouseDoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(198, 18);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 47);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "NOT SİL";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNewNote
            // 
            this.btnNewNote.Location = new System.Drawing.Point(334, 18);
            this.btnNewNote.Name = "btnNewNote";
            this.btnNewNote.Size = new System.Drawing.Size(130, 47);
            this.btnNewNote.TabIndex = 2;
            this.btnNewNote.Text = "NOT EKLE";
            this.btnNewNote.UseVisualStyleBackColor = true;
            this.btnNewNote.Click += new System.EventHandler(this.btnNewNote_Click);
            // 
            // lnkChangePassword
            // 
            this.lnkChangePassword.AutoSize = true;
            this.lnkChangePassword.Location = new System.Drawing.Point(18, 433);
            this.lnkChangePassword.Name = "lnkChangePassword";
            this.lnkChangePassword.Size = new System.Drawing.Size(100, 20);
            this.lnkChangePassword.TabIndex = 3;
            this.lnkChangePassword.TabStop = true;
            this.lnkChangePassword.Text = "Şifre Değiştir";
            this.lnkChangePassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkChangePassword_LinkClicked);
            // 
            // txtHeader
            // 
            this.txtHeader.Location = new System.Drawing.Point(198, 72);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(266, 26);
            this.txtHeader.TabIndex = 4;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(198, 105);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(266, 297);
            this.txtNote.TabIndex = 5;
            // 
            // pbSaveNote
            // 
            this.pbSaveNote.Image = global::NotDefteriUygulamasi.Properties.Resources.Screenshot_7;
            this.pbSaveNote.Location = new System.Drawing.Point(410, 408);
            this.pbSaveNote.Name = "pbSaveNote";
            this.pbSaveNote.Size = new System.Drawing.Size(54, 50);
            this.pbSaveNote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSaveNote.TabIndex = 6;
            this.pbSaveNote.TabStop = false;
            this.pbSaveNote.Click += new System.EventHandler(this.pbSaveNote_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 486);
            this.Controls.Add(this.pbSaveNote);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtHeader);
            this.Controls.Add(this.lnkChangePassword);
            this.Controls.Add(this.btnNewNote);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbNoteHeaders);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSaveNote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbNoteHeaders;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNewNote;
        private System.Windows.Forms.LinkLabel lnkChangePassword;
        private System.Windows.Forms.TextBox txtHeader;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.PictureBox pbSaveNote;
    }
}