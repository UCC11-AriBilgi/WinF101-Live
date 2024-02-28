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
            frmListBoxToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            kontrollerToolStripMenuItem = new ToolStripMenuItem();
            checkControlsToolStripMenuItem = new ToolStripMenuItem();
            checkedListBoxToolStripMenuItem = new ToolStripMenuItem();
            dateTimePickerToolStripMenuItem = new ToolStripMenuItem();
            timerToolStripMenuItem = new ToolStripMenuItem();
            numericUpDownToolStripMenuItem = new ToolStripMenuItem();
            menuMain.SuspendLayout();
            SuspendLayout();
            // 
            // btonExit
            // 
            btonExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btonExit.Location = new Point(597, 329);
            btonExit.Margin = new Padding(3, 2, 3, 2);
            btonExit.Name = "btonExit";
            btonExit.Size = new Size(82, 22);
            btonExit.TabIndex = 0;
            btonExit.Text = "Çıkış";
            btonExit.UseVisualStyleBackColor = true;
            btonExit.Click += btonExit_Click;
            // 
            // menuMain
            // 
            menuMain.ImageScalingSize = new Size(20, 20);
            menuMain.Items.AddRange(new ToolStripItem[] { programToolStripMenuItem, kontrollerToolStripMenuItem });
            menuMain.Location = new Point(0, 0);
            menuMain.Name = "menuMain";
            menuMain.Padding = new Padding(5, 2, 0, 2);
            menuMain.Size = new Size(696, 24);
            menuMain.TabIndex = 1;
            menuMain.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            programToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { frmSampleFormToolStripMenuItem, frmCoToolStripMenuItem, frmListBoxToolStripMenuItem, toolStripSeparator1, çıkışToolStripMenuItem });
            programToolStripMenuItem.Name = "programToolStripMenuItem";
            programToolStripMenuItem.Size = new Size(65, 20);
            programToolStripMenuItem.Text = "Program";
            // 
            // frmSampleFormToolStripMenuItem
            // 
            frmSampleFormToolStripMenuItem.Name = "frmSampleFormToolStripMenuItem";
            frmSampleFormToolStripMenuItem.Size = new Size(160, 22);
            frmSampleFormToolStripMenuItem.Text = "frmSampleForm";
            frmSampleFormToolStripMenuItem.Click += frmSampleFormToolStripMenuItem_Click;
            // 
            // frmCoToolStripMenuItem
            // 
            frmCoToolStripMenuItem.Name = "frmCoToolStripMenuItem";
            frmCoToolStripMenuItem.Size = new Size(160, 22);
            frmCoToolStripMenuItem.Text = "frmCombo";
            frmCoToolStripMenuItem.Click += frmCoToolStripMenuItem_Click;
            // 
            // frmListBoxToolStripMenuItem
            // 
            frmListBoxToolStripMenuItem.Name = "frmListBoxToolStripMenuItem";
            frmListBoxToolStripMenuItem.Size = new Size(160, 22);
            frmListBoxToolStripMenuItem.Text = "frmListBox";
            frmListBoxToolStripMenuItem.Click += frmListBoxToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(157, 6);
            // 
            // çıkışToolStripMenuItem
            // 
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.Size = new Size(160, 22);
            çıkışToolStripMenuItem.Text = "Çıkış";
            çıkışToolStripMenuItem.Click += çıkışToolStripMenuItem_Click_1;
            // 
            // kontrollerToolStripMenuItem
            // 
            kontrollerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { checkControlsToolStripMenuItem, checkedListBoxToolStripMenuItem, dateTimePickerToolStripMenuItem, timerToolStripMenuItem, numericUpDownToolStripMenuItem });
            kontrollerToolStripMenuItem.Name = "kontrollerToolStripMenuItem";
            kontrollerToolStripMenuItem.Size = new Size(71, 20);
            kontrollerToolStripMenuItem.Text = "Kontroller";
            // 
            // checkControlsToolStripMenuItem
            // 
            checkControlsToolStripMenuItem.Name = "checkControlsToolStripMenuItem";
            checkControlsToolStripMenuItem.Size = new Size(180, 22);
            checkControlsToolStripMenuItem.Text = "CheckControls";
            checkControlsToolStripMenuItem.Click += checkControlsToolStripMenuItem_Click;
            // 
            // checkedListBoxToolStripMenuItem
            // 
            checkedListBoxToolStripMenuItem.Name = "checkedListBoxToolStripMenuItem";
            checkedListBoxToolStripMenuItem.Size = new Size(180, 22);
            checkedListBoxToolStripMenuItem.Text = "CheckedListBox";
            checkedListBoxToolStripMenuItem.Click += checkedListBoxToolStripMenuItem_Click;
            // 
            // dateTimePickerToolStripMenuItem
            // 
            dateTimePickerToolStripMenuItem.Name = "dateTimePickerToolStripMenuItem";
            dateTimePickerToolStripMenuItem.Size = new Size(180, 22);
            dateTimePickerToolStripMenuItem.Text = "DateTimePicker";
            dateTimePickerToolStripMenuItem.Click += dateTimePickerToolStripMenuItem_Click;
            // 
            // timerToolStripMenuItem
            // 
            timerToolStripMenuItem.Name = "timerToolStripMenuItem";
            timerToolStripMenuItem.Size = new Size(180, 22);
            timerToolStripMenuItem.Text = "Timer";
            timerToolStripMenuItem.Click += timerToolStripMenuItem_Click;
            // 
            // numericUpDownToolStripMenuItem
            // 
            numericUpDownToolStripMenuItem.Name = "numericUpDownToolStripMenuItem";
            numericUpDownToolStripMenuItem.Size = new Size(180, 22);
            numericUpDownToolStripMenuItem.Text = "NumericUpDown";
            numericUpDownToolStripMenuItem.Click += numericUpDownToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 361);
            ControlBox = false;
            Controls.Add(btonExit);
            Controls.Add(menuMain);
            MainMenuStrip = menuMain;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmMain";
            Text = "Main Form";
            WindowState = FormWindowState.Maximized;
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
        private ToolStripMenuItem frmListBoxToolStripMenuItem;
        private ToolStripMenuItem kontrollerToolStripMenuItem;
        private ToolStripMenuItem checkControlsToolStripMenuItem;
        private ToolStripMenuItem checkedListBoxToolStripMenuItem;
        private ToolStripMenuItem dateTimePickerToolStripMenuItem;
        private ToolStripMenuItem timerToolStripMenuItem;
        private ToolStripMenuItem numericUpDownToolStripMenuItem;
    }
}