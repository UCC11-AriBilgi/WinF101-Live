namespace Forms
{
    partial class frmDateDiffer
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
            label1 = new Label();
            label2 = new Label();
            dtpStart = new DateTimePicker();
            dtpEnd = new DateTimePicker();
            button2 = new Button();
            lboxResult = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(287, 273);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Kapat";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 27);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 1;
            label1.Text = "Başlangıç Tarihi :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 67);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 2;
            label2.Text = "Bitiş Tarihi :";
            // 
            // dtpStart
            // 
            dtpStart.Location = new Point(138, 21);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(200, 23);
            dtpStart.TabIndex = 3;
            // 
            // dtpEnd
            // 
            dtpEnd.CustomFormat = "dd.MM.yyyy hh:mm";
            dtpEnd.Format = DateTimePickerFormat.Custom;
            dtpEnd.Location = new Point(138, 61);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(200, 23);
            dtpEnd.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(138, 102);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lboxResult
            // 
            lboxResult.FormattingEnabled = true;
            lboxResult.ItemHeight = 15;
            lboxResult.Location = new Point(138, 142);
            lboxResult.Name = "lboxResult";
            lboxResult.Size = new Size(200, 94);
            lboxResult.TabIndex = 6;
            // 
            // frmDateDiffer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 308);
            Controls.Add(lboxResult);
            Controls.Add(button2);
            Controls.Add(dtpEnd);
            Controls.Add(dtpStart);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "frmDateDiffer";
            Text = "frmDateDiffer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private Button button2;
        private ListBox lboxResult;
    }
}