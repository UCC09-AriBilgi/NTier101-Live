namespace NTier101_Live.PL
{
    partial class frmLogin
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
            label1 = new Label();
            tboxUserName = new TextBox();
            label2 = new Label();
            tboxUserPassw = new TextBox();
            btonLogin = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 70);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı";
            // 
            // tboxUserName
            // 
            tboxUserName.Location = new Point(232, 67);
            tboxUserName.MaxLength = 10;
            tboxUserName.Name = "tboxUserName";
            tboxUserName.Size = new Size(100, 23);
            tboxUserName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 112);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 2;
            label2.Text = "Kullanıcı Şifre";
            // 
            // tboxUserPassw
            // 
            tboxUserPassw.Location = new Point(232, 109);
            tboxUserPassw.MaxLength = 10;
            tboxUserPassw.Name = "tboxUserPassw";
            tboxUserPassw.Size = new Size(100, 23);
            tboxUserPassw.TabIndex = 3;
            // 
            // btonLogin
            // 
            btonLogin.Location = new Point(232, 160);
            btonLogin.Name = "btonLogin";
            btonLogin.Size = new Size(75, 23);
            btonLogin.TabIndex = 4;
            btonLogin.Text = "Giriş";
            btonLogin.UseVisualStyleBackColor = true;
            btonLogin.Click += btonLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.kullaniciGirisi;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 192, 192);
            label3.Location = new Point(118, 12);
            label3.Name = "label3";
            label3.Size = new Size(219, 25);
            label3.TabIndex = 6;
            label3.Text = "otomasyon sistemi v1.0";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 199);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(btonLogin);
            Controls.Add(tboxUserPassw);
            Controls.Add(label2);
            Controls.Add(tboxUserName);
            Controls.Add(label1);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Giriş";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tboxUserName;
        private Label label2;
        private TextBox tboxUserPassw;
        private Button btonLogin;
        private PictureBox pictureBox1;
        private Label label3;
    }
}