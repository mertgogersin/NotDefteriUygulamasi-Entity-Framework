
namespace NotDefteriUygulamasi
{
    partial class frmAdmin
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
            this.lstPassiveUsers = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstPassiveUsers
            // 
            this.lstPassiveUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lstPassiveUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPassiveUsers.FullRowSelect = true;
            this.lstPassiveUsers.GridLines = true;
            this.lstPassiveUsers.HideSelection = false;
            this.lstPassiveUsers.Location = new System.Drawing.Point(0, 0);
            this.lstPassiveUsers.Name = "lstPassiveUsers";
            this.lstPassiveUsers.Size = new System.Drawing.Size(536, 385);
            this.lstPassiveUsers.TabIndex = 0;
            this.lstPassiveUsers.UseCompatibleStateImageBehavior = false;
            this.lstPassiveUsers.View = System.Windows.Forms.View.Details;
          
            this.lstPassiveUsers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstPassiveUsers_MouseDoubleClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ad";
            this.columnHeader3.Width = 125;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Soyad";
            this.columnHeader6.Width = 128;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Kullanıcı Adı";
            this.columnHeader7.Width = 146;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Durum";
            this.columnHeader8.Width = 133;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 385);
            this.Controls.Add(this.lstPassiveUsers);
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstPassiveUsers;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}