﻿namespace NTier101_Live.PL.User
{
    partial class frmUserDelete
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
            dgrdUser = new DataGridView();
            groupBox1 = new GroupBox();
            tboxUserName = new TextBox();
            tboxUserPassw = new TextBox();
            tboxAd = new TextBox();
            btonSave = new Button();
            tboxSoyad = new TextBox();
            tboxMudurlukID = new TextBox();
            tboxTCKimlik = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgrdUser).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgrdUser
            // 
            dgrdUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrdUser.Location = new Point(12, 12);
            dgrdUser.Name = "dgrdUser";
            dgrdUser.RowTemplate.Height = 25;
            dgrdUser.Size = new Size(405, 150);
            dgrdUser.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tboxUserName);
            groupBox1.Controls.Add(tboxUserPassw);
            groupBox1.Controls.Add(tboxAd);
            groupBox1.Controls.Add(btonSave);
            groupBox1.Controls.Add(tboxSoyad);
            groupBox1.Controls.Add(tboxMudurlukID);
            groupBox1.Controls.Add(tboxTCKimlik);
            groupBox1.Location = new Point(12, 168);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(479, 196);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kullanıcı Detay";
            // 
            // tboxUserName
            // 
            tboxUserName.Location = new Point(60, 32);
            tboxUserName.MaxLength = 10;
            tboxUserName.Name = "tboxUserName";
            tboxUserName.Size = new Size(100, 23);
            tboxUserName.TabIndex = 0;
            // 
            // tboxUserPassw
            // 
            tboxUserPassw.Location = new Point(60, 61);
            tboxUserPassw.MaxLength = 10;
            tboxUserPassw.Name = "tboxUserPassw";
            tboxUserPassw.Size = new Size(100, 23);
            tboxUserPassw.TabIndex = 1;
            // 
            // tboxAd
            // 
            tboxAd.Location = new Point(255, 32);
            tboxAd.Name = "tboxAd";
            tboxAd.Size = new Size(142, 23);
            tboxAd.TabIndex = 2;
            // 
            // btonSave
            // 
            btonSave.Location = new Point(398, 167);
            btonSave.Name = "btonSave";
            btonSave.Size = new Size(75, 23);
            btonSave.TabIndex = 6;
            btonSave.Text = "Kayıt";
            btonSave.UseVisualStyleBackColor = true;
            // 
            // tboxSoyad
            // 
            tboxSoyad.Location = new Point(255, 61);
            tboxSoyad.Name = "tboxSoyad";
            tboxSoyad.Size = new Size(142, 23);
            tboxSoyad.TabIndex = 3;
            // 
            // tboxMudurlukID
            // 
            tboxMudurlukID.Location = new Point(255, 117);
            tboxMudurlukID.Name = "tboxMudurlukID";
            tboxMudurlukID.Size = new Size(32, 23);
            tboxMudurlukID.TabIndex = 5;
            // 
            // tboxTCKimlik
            // 
            tboxTCKimlik.Location = new Point(255, 90);
            tboxTCKimlik.MaxLength = 11;
            tboxTCKimlik.Name = "tboxTCKimlik";
            tboxTCKimlik.Size = new Size(100, 23);
            tboxTCKimlik.TabIndex = 4;
            // 
            // frmUserDelete
            // 
            AccessibleRole = AccessibleRole.PageTabList;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 413);
            ControlBox = false;
            Controls.Add(groupBox1);
            Controls.Add(dgrdUser);
            Name = "frmUserDelete";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmUserDelete";
            ((System.ComponentModel.ISupportInitialize)dgrdUser).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgrdUser;
        private GroupBox groupBox1;
        private TextBox tboxUserName;
        private TextBox tboxUserPassw;
        private TextBox tboxAd;
        private Button btonSave;
        private TextBox tboxSoyad;
        private TextBox tboxMudurlukID;
        private TextBox tboxTCKimlik;
    }
}