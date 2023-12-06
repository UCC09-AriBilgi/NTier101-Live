namespace NTier101_Live.PL.User
{
    partial class frmUserInsert
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
            tboxUserName = new TextBox();
            tboxUserPassw = new TextBox();
            tboxAd = new TextBox();
            tboxSoyad = new TextBox();
            tboxTCKimlik = new TextBox();
            tboxMudurlukID = new TextBox();
            btonSave = new Button();
            btonClose = new Button();
            dgrdUser = new DataGridView();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgrdUser).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            // tboxSoyad
            // 
            tboxSoyad.Location = new Point(255, 61);
            tboxSoyad.Name = "tboxSoyad";
            tboxSoyad.Size = new Size(142, 23);
            tboxSoyad.TabIndex = 3;
            // 
            // tboxTCKimlik
            // 
            tboxTCKimlik.Location = new Point(255, 90);
            tboxTCKimlik.MaxLength = 11;
            tboxTCKimlik.Name = "tboxTCKimlik";
            tboxTCKimlik.Size = new Size(100, 23);
            tboxTCKimlik.TabIndex = 4;
            // 
            // tboxMudurlukID
            // 
            tboxMudurlukID.Location = new Point(255, 117);
            tboxMudurlukID.Name = "tboxMudurlukID";
            tboxMudurlukID.Size = new Size(32, 23);
            tboxMudurlukID.TabIndex = 5;
            // 
            // btonSave
            // 
            btonSave.Location = new Point(398, 167);
            btonSave.Name = "btonSave";
            btonSave.Size = new Size(75, 23);
            btonSave.TabIndex = 6;
            btonSave.Text = "Kayıt";
            btonSave.UseVisualStyleBackColor = true;
            btonSave.Click += btonSave_Click;
            // 
            // btonClose
            // 
            btonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btonClose.Location = new Point(412, 373);
            btonClose.Name = "btonClose";
            btonClose.Size = new Size(75, 23);
            btonClose.TabIndex = 7;
            btonClose.Text = "Kapat";
            btonClose.UseVisualStyleBackColor = true;
            btonClose.Click += btonClose_Click;
            // 
            // dgrdUser
            // 
            dgrdUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrdUser.Location = new Point(12, 12);
            dgrdUser.Name = "dgrdUser";
            dgrdUser.RowTemplate.Height = 25;
            dgrdUser.Size = new Size(479, 150);
            dgrdUser.TabIndex = 8;
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
            groupBox1.Location = new Point(12, 171);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(479, 196);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kullanıcı Detay";
            // 
            // frmUserInsert
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 402);
            ControlBox = false;
            Controls.Add(groupBox1);
            Controls.Add(dgrdUser);
            Controls.Add(btonClose);
            Name = "frmUserInsert";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmUserInsert";
            Load += frmUserInsert_Load;
            ((System.ComponentModel.ISupportInitialize)dgrdUser).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tboxUserName;
        private TextBox tboxUserPassw;
        private TextBox tboxAd;
        private TextBox tboxSoyad;
        private TextBox tboxTCKimlik;
        private TextBox tboxMudurlukID;
        private Button btonSave;
        private Button btonClose;
        private DataGridView dgrdUser;
        private GroupBox groupBox1;
    }
}