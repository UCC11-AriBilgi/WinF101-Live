namespace Forms
{
    partial class frmDateTimePicker
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
            btonClose = new Button();
            label1 = new Label();
            tboxAdSoyad = new TextBox();
            label2 = new Label();
            dtpCalendar = new DateTimePicker();
            btonGoster = new Button();
            SuspendLayout();
            // 
            // btonClose
            // 
            btonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btonClose.Location = new Point(265, 174);
            btonClose.Name = "btonClose";
            btonClose.Size = new Size(75, 23);
            btonClose.TabIndex = 0;
            btonClose.Text = "Kapat";
            btonClose.UseVisualStyleBackColor = true;
            btonClose.Click += btonClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 24);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 1;
            label1.Text = "Ad Soyad";
            // 
            // tboxAdSoyad
            // 
            tboxAdSoyad.Location = new Point(134, 21);
            tboxAdSoyad.Name = "tboxAdSoyad";
            tboxAdSoyad.Size = new Size(100, 23);
            tboxAdSoyad.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 65);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 3;
            label2.Text = "Doğum Tarihiniz.";
            // 
            // dtpCalendar
            // 
            dtpCalendar.Location = new Point(135, 61);
            dtpCalendar.Name = "dtpCalendar";
            dtpCalendar.Size = new Size(200, 23);
            dtpCalendar.TabIndex = 4;
            // 
            // btonGoster
            // 
            btonGoster.Location = new Point(27, 129);
            btonGoster.Name = "btonGoster";
            btonGoster.Size = new Size(75, 23);
            btonGoster.TabIndex = 5;
            btonGoster.Text = "Göster";
            btonGoster.UseVisualStyleBackColor = true;
            btonGoster.Click += btonGoster_Click;
            // 
            // frmDateTimePicker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 209);
            Controls.Add(btonGoster);
            Controls.Add(dtpCalendar);
            Controls.Add(label2);
            Controls.Add(tboxAdSoyad);
            Controls.Add(label1);
            Controls.Add(btonClose);
            Name = "frmDateTimePicker";
            Text = "frmDateTimePicker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btonClose;
        private Label label1;
        private TextBox tboxAdSoyad;
        private Label label2;
        private DateTimePicker dtpCalendar;
        private Button btonGoster;
    }
}