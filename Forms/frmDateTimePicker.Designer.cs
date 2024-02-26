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
            this.btonClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxAdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpCalendar = new System.Windows.Forms.DateTimePicker();
            this.btonGoster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btonClose
            // 
            this.btonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btonClose.Location = new System.Drawing.Point(310, 293);
            this.btonClose.Name = "btonClose";
            this.btonClose.Size = new System.Drawing.Size(75, 23);
            this.btonClose.TabIndex = 0;
            this.btonClose.Text = "Kapat";
            this.btonClose.UseVisualStyleBackColor = true;
            this.btonClose.Click += new System.EventHandler(this.btonClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad Soyad";
            // 
            // tboxAdSoyad
            // 
            this.tboxAdSoyad.Location = new System.Drawing.Point(134, 21);
            this.tboxAdSoyad.Name = "tboxAdSoyad";
            this.tboxAdSoyad.Size = new System.Drawing.Size(100, 23);
            this.tboxAdSoyad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Doğum Tarihiniz.";
            // 
            // dtpCalendar
            // 
            this.dtpCalendar.Location = new System.Drawing.Point(135, 61);
            this.dtpCalendar.Name = "dtpCalendar";
            this.dtpCalendar.Size = new System.Drawing.Size(200, 23);
            this.dtpCalendar.TabIndex = 4;
            // 
            // btonGoster
            // 
            this.btonGoster.Location = new System.Drawing.Point(27, 129);
            this.btonGoster.Name = "btonGoster";
            this.btonGoster.Size = new System.Drawing.Size(75, 23);
            this.btonGoster.TabIndex = 5;
            this.btonGoster.Text = "Göster";
            this.btonGoster.UseVisualStyleBackColor = true;
            this.btonGoster.Click += new System.EventHandler(this.btonGoster_Click);
            // 
            // frmDateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 328);
            this.Controls.Add(this.btonGoster);
            this.Controls.Add(this.dtpCalendar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxAdSoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btonClose);
            this.Name = "frmDateTimePicker";
            this.Text = "frmDateTimePicker";
            this.ResumeLayout(false);
            this.PerformLayout();

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