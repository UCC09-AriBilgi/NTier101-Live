namespace NTier101_Live.PL.User
{
    partial class frmUser
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
            grpbUser = new GroupBox();
            btonSave = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tboxUserName = new TextBox();
            tboxUserPassw = new TextBox();
            tboxAd = new TextBox();
            tboxSoyad = new TextBox();
            tboxMudurlukID = new TextBox();
            tboxTCKimlik = new TextBox();
            btonClose = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pboxNew = new PictureBox();
            pboxUpdate = new PictureBox();
            pboxDelete = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgrdUser).BeginInit();
            grpbUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxNew).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxUpdate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxDelete).BeginInit();
            SuspendLayout();
            // 
            // dgrdUser
            // 
            dgrdUser.AllowUserToAddRows = false;
            dgrdUser.AllowUserToDeleteRows = false;
            dgrdUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrdUser.Location = new Point(133, 41);
            dgrdUser.Name = "dgrdUser";
            dgrdUser.ReadOnly = true;
            dgrdUser.RowHeadersVisible = false;
            dgrdUser.RowTemplate.Height = 25;
            dgrdUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgrdUser.Size = new Size(622, 150);
            dgrdUser.TabIndex = 0;
            dgrdUser.CellContentClick += dgrdUser_CellContentClick;
            dgrdUser.CellContentDoubleClick += dgrdUser_CellContentDoubleClick;
            // 
            // grpbUser
            // 
            grpbUser.Controls.Add(btonSave);
            grpbUser.Controls.Add(label7);
            grpbUser.Controls.Add(label6);
            grpbUser.Controls.Add(label5);
            grpbUser.Controls.Add(label4);
            grpbUser.Controls.Add(label3);
            grpbUser.Controls.Add(label2);
            grpbUser.Controls.Add(tboxUserName);
            grpbUser.Controls.Add(tboxUserPassw);
            grpbUser.Controls.Add(tboxAd);
            grpbUser.Controls.Add(tboxSoyad);
            grpbUser.Controls.Add(tboxMudurlukID);
            grpbUser.Controls.Add(tboxTCKimlik);
            grpbUser.Location = new Point(133, 276);
            grpbUser.Name = "grpbUser";
            grpbUser.Size = new Size(479, 204);
            grpbUser.TabIndex = 10;
            grpbUser.TabStop = false;
            grpbUser.Text = "Kullanıcı Detay";
            // 
            // btonSave
            // 
            btonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btonSave.Location = new Point(398, 175);
            btonSave.Name = "btonSave";
            btonSave.Size = new Size(75, 23);
            btonSave.TabIndex = 19;
            btonSave.Text = "Kaydet";
            btonSave.UseVisualStyleBackColor = true;
            btonSave.Click += btonSave_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(16, 162);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 18;
            label7.Text = "Müdürlük";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(16, 133);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 17;
            label6.Text = "TC Kimlik No";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(16, 104);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 16;
            label5.Text = "Soyad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(16, 75);
            label4.Name = "label4";
            label4.Size = new Size(22, 15);
            label4.TabIndex = 15;
            label4.Text = "Ad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(230, 35);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 14;
            label3.Text = "Kullanıcı Şifre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(16, 35);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 13;
            label2.Text = "Kullanıcı Adı";
            // 
            // tboxUserName
            // 
            tboxUserName.Location = new Point(105, 32);
            tboxUserName.MaxLength = 10;
            tboxUserName.Name = "tboxUserName";
            tboxUserName.Size = new Size(100, 23);
            tboxUserName.TabIndex = 0;
            // 
            // tboxUserPassw
            // 
            tboxUserPassw.Location = new Point(319, 32);
            tboxUserPassw.MaxLength = 10;
            tboxUserPassw.Name = "tboxUserPassw";
            tboxUserPassw.Size = new Size(100, 23);
            tboxUserPassw.TabIndex = 1;
            // 
            // tboxAd
            // 
            tboxAd.Location = new Point(105, 72);
            tboxAd.Name = "tboxAd";
            tboxAd.Size = new Size(142, 23);
            tboxAd.TabIndex = 2;
            // 
            // tboxSoyad
            // 
            tboxSoyad.Location = new Point(105, 101);
            tboxSoyad.Name = "tboxSoyad";
            tboxSoyad.Size = new Size(142, 23);
            tboxSoyad.TabIndex = 3;
            // 
            // tboxMudurlukID
            // 
            tboxMudurlukID.Location = new Point(105, 159);
            tboxMudurlukID.Name = "tboxMudurlukID";
            tboxMudurlukID.Size = new Size(32, 23);
            tboxMudurlukID.TabIndex = 5;
            // 
            // tboxTCKimlik
            // 
            tboxTCKimlik.Location = new Point(105, 130);
            tboxTCKimlik.MaxLength = 11;
            tboxTCKimlik.Name = "tboxTCKimlik";
            tboxTCKimlik.Size = new Size(100, 23);
            tboxTCKimlik.TabIndex = 4;
            // 
            // btonClose
            // 
            btonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btonClose.Location = new Point(752, 476);
            btonClose.Name = "btonClose";
            btonClose.Size = new Size(75, 23);
            btonClose.TabIndex = 9;
            btonClose.Text = "Kapat";
            btonClose.UseVisualStyleBackColor = true;
            btonClose.Click += btonClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(133, 9);
            label1.Name = "label1";
            label1.Size = new Size(150, 21);
            label1.TabIndex = 11;
            label1.Text = "Kayıtlı Kullanıcılar";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.kullaniciGirisi;
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // pboxNew
            // 
            pboxNew.Cursor = Cursors.Hand;
            pboxNew.Image = Properties.Resources.add_user;
            pboxNew.Location = new Point(141, 199);
            pboxNew.Name = "pboxNew";
            pboxNew.Size = new Size(48, 51);
            pboxNew.SizeMode = PictureBoxSizeMode.StretchImage;
            pboxNew.TabIndex = 13;
            pboxNew.TabStop = false;
            pboxNew.Click += pboxNew_Click;
            pboxNew.DoubleClick += pboxNew_DoubleClick;
            // 
            // pboxUpdate
            // 
            pboxUpdate.Cursor = Cursors.Hand;
            pboxUpdate.Image = Properties.Resources.edit_profile;
            pboxUpdate.Location = new Point(217, 200);
            pboxUpdate.Name = "pboxUpdate";
            pboxUpdate.Size = new Size(53, 50);
            pboxUpdate.SizeMode = PictureBoxSizeMode.StretchImage;
            pboxUpdate.TabIndex = 14;
            pboxUpdate.TabStop = false;
            pboxUpdate.Click += pboxUpdate_Click;
            // 
            // pboxDelete
            // 
            pboxDelete.Cursor = Cursors.Hand;
            pboxDelete.Image = Properties.Resources.delete_user;
            pboxDelete.Location = new Point(295, 200);
            pboxDelete.Name = "pboxDelete";
            pboxDelete.Size = new Size(52, 50);
            pboxDelete.SizeMode = PictureBoxSizeMode.StretchImage;
            pboxDelete.TabIndex = 15;
            pboxDelete.TabStop = false;
            pboxDelete.Click += pboxDelete_Click;
            // 
            // frmUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 503);
            ControlBox = false;
            Controls.Add(pboxDelete);
            Controls.Add(pboxUpdate);
            Controls.Add(pboxNew);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btonClose);
            Controls.Add(grpbUser);
            Controls.Add(dgrdUser);
            Name = "frmUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Bilgileri";
            Load += frmUser_Load;
            ((System.ComponentModel.ISupportInitialize)dgrdUser).EndInit();
            grpbUser.ResumeLayout(false);
            grpbUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxNew).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxUpdate).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxDelete).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgrdUser;
        private GroupBox grpbUser;
        private TextBox tboxUserName;
        private TextBox tboxUserPassw;
        private TextBox tboxAd;
        private TextBox tboxSoyad;
        private TextBox tboxMudurlukID;
        private TextBox tboxTCKimlik;
        private Button btonClose;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pboxNew;
        private PictureBox pboxUpdate;
        private PictureBox pboxDelete;
        private Button btonSave;
    }
}