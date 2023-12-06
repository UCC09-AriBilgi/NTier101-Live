namespace NTier101_Live.PL
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
            btonExit = new Button();
            menuNTier = new MenuStrip();
            kullanıcıToolStripMenuItem = new ToolStripMenuItem();
            yeniToolStripMenuItem = new ToolStripMenuItem();
            silToolStripMenuItem = new ToolStripMenuItem();
            güncelleToolStripMenuItem = new ToolStripMenuItem();
            menuNTier.SuspendLayout();
            SuspendLayout();
            // 
            // btonExit
            // 
            btonExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btonExit.Location = new Point(732, 415);
            btonExit.Name = "btonExit";
            btonExit.Size = new Size(75, 23);
            btonExit.TabIndex = 0;
            btonExit.Text = "Çıkış";
            btonExit.UseVisualStyleBackColor = true;
            btonExit.Click += btonExit_Click;
            // 
            // menuNTier
            // 
            menuNTier.Items.AddRange(new ToolStripItem[] { kullanıcıToolStripMenuItem });
            menuNTier.Location = new Point(0, 0);
            menuNTier.Name = "menuNTier";
            menuNTier.Size = new Size(819, 24);
            menuNTier.TabIndex = 1;
            menuNTier.Text = "menuStrip1";
            // 
            // kullanıcıToolStripMenuItem
            // 
            kullanıcıToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { yeniToolStripMenuItem, silToolStripMenuItem, güncelleToolStripMenuItem });
            kullanıcıToolStripMenuItem.Name = "kullanıcıToolStripMenuItem";
            kullanıcıToolStripMenuItem.Size = new Size(64, 20);
            kullanıcıToolStripMenuItem.Text = "Kullanıcı";
            // 
            // yeniToolStripMenuItem
            // 
            yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            yeniToolStripMenuItem.Size = new Size(180, 22);
            yeniToolStripMenuItem.Text = "Yeni";
            // 
            // silToolStripMenuItem
            // 
            silToolStripMenuItem.Name = "silToolStripMenuItem";
            silToolStripMenuItem.Size = new Size(180, 22);
            silToolStripMenuItem.Text = "Sil";
            // 
            // güncelleToolStripMenuItem
            // 
            güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            güncelleToolStripMenuItem.Size = new Size(180, 22);
            güncelleToolStripMenuItem.Text = "Güncelle";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 450);
            Controls.Add(btonExit);
            Controls.Add(menuNTier);
            MainMenuStrip = menuNTier;
            Name = "frmMain";
            Text = "Ana Ekran";
            WindowState = FormWindowState.Maximized;
            menuNTier.ResumeLayout(false);
            menuNTier.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btonExit;
        private MenuStrip menuNTier;
        private ToolStripMenuItem kullanıcıToolStripMenuItem;
        private ToolStripMenuItem yeniToolStripMenuItem;
        private ToolStripMenuItem silToolStripMenuItem;
        private ToolStripMenuItem güncelleToolStripMenuItem;
    }
}