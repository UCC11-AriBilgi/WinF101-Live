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
            formlarToolStripMenuItem = new ToolStripMenuItem();
            employeesToolStripMenuItem = new ToolStripMenuItem();
            programToolStripMenuItem = new ToolStripMenuItem();
            dBConnectToolStripMenuItem = new ToolStripMenuItem();
            dBBaglanToolStripMenuItem1 = new ToolStripMenuItem();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btonExit
            // 
            btonExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btonExit.Location = new Point(536, 553);
            btonExit.Margin = new Padding(3, 4, 3, 4);
            btonExit.Name = "btonExit";
            btonExit.Size = new Size(86, 31);
            btonExit.TabIndex = 0;
            btonExit.Text = "Çıkış";
            btonExit.UseVisualStyleBackColor = true;
            btonExit.Click += btonExit_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dBBağlanToolStripMenuItem, programToolStripMenuItem, formlarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(635, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // dBBağlanToolStripMenuItem
            // 
            dBBağlanToolStripMenuItem.Name = "dBBağlanToolStripMenuItem";
            dBBağlanToolStripMenuItem.Size = new Size(14, 24);
            // 
            // formlarToolStripMenuItem
            // 
            formlarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { employeesToolStripMenuItem });
            formlarToolStripMenuItem.Name = "formlarToolStripMenuItem";
            formlarToolStripMenuItem.Size = new Size(74, 24);
            formlarToolStripMenuItem.Text = "Formlar";
            // 
            // employeesToolStripMenuItem
            // 
            employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            employeesToolStripMenuItem.Size = new Size(224, 26);
            employeesToolStripMenuItem.Text = "Employees";
            employeesToolStripMenuItem.Click += GetEmployeeForm;
            // 
            // programToolStripMenuItem
            // 
            programToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dBConnectToolStripMenuItem });
            programToolStripMenuItem.Name = "programToolStripMenuItem";
            programToolStripMenuItem.Size = new Size(80, 24);
            programToolStripMenuItem.Text = "Program";
            // 
            // dBConnectToolStripMenuItem
            // 
            dBConnectToolStripMenuItem.Name = "dBConnectToolStripMenuItem";
            dBConnectToolStripMenuItem.Size = new Size(224, 26);
            dBConnectToolStripMenuItem.Text = "DBConnect";
            dBConnectToolStripMenuItem.Click += Connect;
            // 
            // dBBaglanToolStripMenuItem1
            // 
            dBBaglanToolStripMenuItem1.Name = "dBBaglanToolStripMenuItem1";
            dBBaglanToolStripMenuItem1.Size = new Size(32, 19);
            // 
            // button1
            // 
            button1.Location = new Point(14, 553);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(162, 31);
            button1.TabIndex = 2;
            button1.Text = "Bağlantıyı Kapat";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 600);
            Controls.Add(button1);
            Controls.Add(btonExit);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMain";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btonExit;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dBBağlanToolStripMenuItem;
        private ToolStripMenuItem dBBaglanToolStripMenuItem1;
        private Button button1;
        private ToolStripMenuItem formlarToolStripMenuItem;
        private ToolStripMenuItem employeesToolStripMenuItem;
        private ToolStripMenuItem programToolStripMenuItem;
        private ToolStripMenuItem dBConnectToolStripMenuItem;
    }
}
