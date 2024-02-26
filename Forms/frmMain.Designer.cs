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
            this.btonExit = new System.Windows.Forms.Button();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frmSampleFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frmCoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frmListBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontrollerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedListBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btonExit
            // 
            this.btonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btonExit.Location = new System.Drawing.Point(597, 329);
            this.btonExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btonExit.Name = "btonExit";
            this.btonExit.Size = new System.Drawing.Size(82, 22);
            this.btonExit.TabIndex = 0;
            this.btonExit.Text = "Çıkış";
            this.btonExit.UseVisualStyleBackColor = true;
            this.btonExit.Click += new System.EventHandler(this.btonExit_Click);
            // 
            // menuMain
            // 
            this.menuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.kontrollerToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuMain.Size = new System.Drawing.Size(696, 24);
            this.menuMain.TabIndex = 1;
            this.menuMain.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmSampleFormToolStripMenuItem,
            this.frmCoToolStripMenuItem,
            this.frmListBoxToolStripMenuItem,
            this.toolStripSeparator1,
            this.çıkışToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // frmSampleFormToolStripMenuItem
            // 
            this.frmSampleFormToolStripMenuItem.Name = "frmSampleFormToolStripMenuItem";
            this.frmSampleFormToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.frmSampleFormToolStripMenuItem.Text = "frmSampleForm";
            // 
            // frmCoToolStripMenuItem
            // 
            this.frmCoToolStripMenuItem.Name = "frmCoToolStripMenuItem";
            this.frmCoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.frmCoToolStripMenuItem.Text = "frmCombo";
            // 
            // frmListBoxToolStripMenuItem
            // 
            this.frmListBoxToolStripMenuItem.Name = "frmListBoxToolStripMenuItem";
            this.frmListBoxToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.frmListBoxToolStripMenuItem.Text = "frmListBox";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click_1);
            // 
            // kontrollerToolStripMenuItem
            // 
            this.kontrollerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkControlsToolStripMenuItem,
            this.checkedListBoxToolStripMenuItem});
            this.kontrollerToolStripMenuItem.Name = "kontrollerToolStripMenuItem";
            this.kontrollerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.kontrollerToolStripMenuItem.Text = "Kontroller";
            // 
            // checkControlsToolStripMenuItem
            // 
            this.checkControlsToolStripMenuItem.Name = "checkControlsToolStripMenuItem";
            this.checkControlsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkControlsToolStripMenuItem.Text = "CheckControls";
            this.checkControlsToolStripMenuItem.Click += new System.EventHandler(this.checkControlsToolStripMenuItem_Click);
            // 
            // checkedListBoxToolStripMenuItem
            // 
            this.checkedListBoxToolStripMenuItem.Name = "checkedListBoxToolStripMenuItem";
            this.checkedListBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkedListBoxToolStripMenuItem.Text = "CheckedListBox";
            this.checkedListBoxToolStripMenuItem.Click += new System.EventHandler(this.checkedListBoxToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 361);
            this.ControlBox = false;
            this.Controls.Add(this.btonExit);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.Text = "Main Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btonExit;
        private MenuStrip menuMain;
        private ToolStripMenuItem programToolStripMenuItem;
        private ToolStripMenuItem frmSampleFormToolStripMenuItem;
        private ToolStripMenuItem frmCoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private ToolStripMenuItem frmListBoxToolStripMenuItem;
        private ToolStripMenuItem kontrollerToolStripMenuItem;
        private ToolStripMenuItem checkControlsToolStripMenuItem;
        private ToolStripMenuItem checkedListBoxToolStripMenuItem;
    }
}