namespace ADONet
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btonExit = new Button();
            menuStrip1 = new MenuStrip();
            dBBağlanToolStripMenuItem = new ToolStripMenuItem();
            dBBağlanToolStripMenuItem1 = new ToolStripMenuItem();
            button1 = new Button();
            formlarToolStripMenuItem = new ToolStripMenuItem();
            employeesToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btonExit
            // 
            btonExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btonExit.Location = new Point(469, 415);
            btonExit.Name = "btonExit";
            btonExit.Size = new Size(75, 23);
            btonExit.TabIndex = 0;
            btonExit.Text = "Çıkış";
            btonExit.UseVisualStyleBackColor = true;
            btonExit.Click += btonExit_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { dBBağlanToolStripMenuItem, formlarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(556, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // dBBağlanToolStripMenuItem
            // 
            dBBağlanToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dBBağlanToolStripMenuItem1 });
            dBBağlanToolStripMenuItem.Name = "dBBağlanToolStripMenuItem";
            dBBağlanToolStripMenuItem.Size = new Size(65, 20);
            dBBağlanToolStripMenuItem.Text = "Program";
            dBBağlanToolStripMenuItem.Click += dBBağlanToolStripMenuItem_Click;
            // 
            // dBBağlanToolStripMenuItem1
            // 
            dBBağlanToolStripMenuItem1.Name = "dBBağlanToolStripMenuItem1";
            dBBağlanToolStripMenuItem1.Size = new Size(180, 22);
            dBBağlanToolStripMenuItem1.Text = "DBBağlan";
            dBBağlanToolStripMenuItem1.Click += dBBağlanToolStripMenuItem1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 415);
            button1.Name = "button1";
            button1.Size = new Size(142, 23);
            button1.TabIndex = 2;
            button1.Text = "Bağlantıyı Kapat";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // formlarToolStripMenuItem
            // 
            formlarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { employeesToolStripMenuItem });
            formlarToolStripMenuItem.Name = "formlarToolStripMenuItem";
            formlarToolStripMenuItem.Size = new Size(60, 20);
            formlarToolStripMenuItem.Text = "Formlar";
            // 
            // employeesToolStripMenuItem
            // 
            employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            employeesToolStripMenuItem.Size = new Size(180, 22);
            employeesToolStripMenuItem.Text = "Employees";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 450);
            Controls.Add(button1);
            Controls.Add(btonExit);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btonExit;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dBBağlanToolStripMenuItem;
        private ToolStripMenuItem dBBağlanToolStripMenuItem1;
        private Button button1;
        private ToolStripMenuItem formlarToolStripMenuItem;
        private ToolStripMenuItem employeesToolStripMenuItem;
    }
}
