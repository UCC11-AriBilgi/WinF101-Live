namespace Forms
{
    partial class frmListBoxTransfer
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
            button1 = new Button();
            lboxSource = new ListBox();
            lboxDest = new ListBox();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(328, 271);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Çıkış";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lboxSource
            // 
            lboxSource.FormattingEnabled = true;
            lboxSource.ItemHeight = 15;
            lboxSource.Items.AddRange(new object[] { "İstanbul", "Ankara", "İzmir", "Bursa", "Muğla", "Antalya", "Bolu" });
            lboxSource.Location = new Point(21, 51);
            lboxSource.Name = "lboxSource";
            lboxSource.Size = new Size(120, 154);
            lboxSource.TabIndex = 1;
            // 
            // lboxDest
            // 
            lboxDest.FormattingEnabled = true;
            lboxDest.ItemHeight = 15;
            lboxDest.Location = new Point(267, 51);
            lboxDest.Name = "lboxDest";
            lboxDest.Size = new Size(120, 154);
            lboxDest.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 33);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 3;
            label1.Text = "Source";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(267, 33);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 4;
            label2.Text = "Destination";
            // 
            // button2
            // 
            button2.Location = new Point(167, 70);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = ">";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(167, 99);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = ">>";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(167, 128);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 7;
            button4.Text = "<";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(167, 157);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 8;
            button5.Text = "<<";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // frmListBoxTransfer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 306);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lboxDest);
            Controls.Add(lboxSource);
            Controls.Add(button1);
            Name = "frmListBoxTransfer";
            Text = "frmListBoxTransfer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox lboxSource;
        private ListBox lboxDest;
        private Label label1;
        private Label label2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}