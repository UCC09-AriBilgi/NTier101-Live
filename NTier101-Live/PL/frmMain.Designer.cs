﻿namespace NTier101_Live.PL
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
            bilgilerToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
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
            kullanıcıToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bilgilerToolStripMenuItem, toolStripSeparator1, çıkışToolStripMenuItem });
            kullanıcıToolStripMenuItem.Name = "kullanıcıToolStripMenuItem";
            kullanıcıToolStripMenuItem.Size = new Size(64, 20);
            kullanıcıToolStripMenuItem.Text = "Kullanıcı";
            // 
            // bilgilerToolStripMenuItem
            // 
            bilgilerToolStripMenuItem.Name = "bilgilerToolStripMenuItem";
            bilgilerToolStripMenuItem.Size = new Size(110, 22);
            bilgilerToolStripMenuItem.Text = "Bilgiler";
            bilgilerToolStripMenuItem.Click += bilgilerToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(107, 6);
            // 
            // çıkışToolStripMenuItem
            // 
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.Size = new Size(110, 22);
            çıkışToolStripMenuItem.Text = "Çıkış";
            çıkışToolStripMenuItem.Click += çıkışToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 450);
            ControlBox = false;
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
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private ToolStripMenuItem bilgilerToolStripMenuItem;
    }
}