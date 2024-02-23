namespace Forms
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
            menuMain = new MenuStrip();
            programToolStripMenuItem = new ToolStripMenuItem();
            frmSampleFormToolStripMenuItem = new ToolStripMenuItem();
            frmCoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            menuMain.SuspendLayout();
            SuspendLayout();
            // 
            // btonExit
            // 
            btonExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btonExit.Location = new Point(682, 439);
            btonExit.Name = "btonExit";
            btonExit.Size = new Size(94, 29);
            btonExit.TabIndex = 0;
            btonExit.Text = "Çıkış";
            btonExit.UseVisualStyleBackColor = true;
            btonExit.Click += btonExit_Click;
            // 
            // menuMain
            // 
            menuMain.ImageScalingSize = new Size(20, 20);
            menuMain.Items.AddRange(new ToolStripItem[] { programToolStripMenuItem });
            menuMain.Location = new Point(0, 0);
            menuMain.Name = "menuMain";
            menuMain.Size = new Size(795, 28);
            menuMain.TabIndex = 1;
            menuMain.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            programToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { frmSampleFormToolStripMenuItem, frmCoToolStripMenuItem, toolStripSeparator1, çıkışToolStripMenuItem });
            programToolStripMenuItem.Name = "programToolStripMenuItem";
            programToolStripMenuItem.Size = new Size(80, 24);
            programToolStripMenuItem.Text = "Program";
            // 
            // frmSampleFormToolStripMenuItem
            // 
            frmSampleFormToolStripMenuItem.Name = "frmSampleFormToolStripMenuItem";
            frmSampleFormToolStripMenuItem.Size = new Size(224, 26);
            frmSampleFormToolStripMenuItem.Text = "frmSampleForm";
            frmSampleFormToolStripMenuItem.Click += frmSampleFormToolStripMenuItem_Click;
            // 
            // frmCoToolStripMenuItem
            // 
            frmCoToolStripMenuItem.Name = "frmCoToolStripMenuItem";
            frmCoToolStripMenuItem.Size = new Size(224, 26);
            frmCoToolStripMenuItem.Text = "frmCombo";
            frmCoToolStripMenuItem.Click += frmCoToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(221, 6);
            // 
            // çıkışToolStripMenuItem
            // 
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.Size = new Size(224, 26);
            çıkışToolStripMenuItem.Text = "Çıkış";
            çıkışToolStripMenuItem.Click += çıkışToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 481);
            ControlBox = false;
            Controls.Add(btonExit);
            Controls.Add(menuMain);
            MainMenuStrip = menuMain;
            Name = "frmMain";
            Text = "Main Form";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            menuMain.ResumeLayout(false);
            menuMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btonExit;
        private MenuStrip menuMain;
        private ToolStripMenuItem programToolStripMenuItem;
        private ToolStripMenuItem frmSampleFormToolStripMenuItem;
        private ToolStripMenuItem frmCoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem çıkışToolStripMenuItem;
    }
}