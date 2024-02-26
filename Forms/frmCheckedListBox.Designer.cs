namespace Forms
{
    partial class frmCheckedListBox
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
            this.chlbDiller = new System.Windows.Forms.CheckedListBox();
            this.btonMesaj = new System.Windows.Forms.Button();
            this.lbelMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btonClose
            // 
            this.btonClose.Location = new System.Drawing.Point(445, 415);
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
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hangi programlama dillerini kullanıyorsunuz?";
            // 
            // chlbDiller
            // 
            this.chlbDiller.FormattingEnabled = true;
            this.chlbDiller.Items.AddRange(new object[] {
            "CSharp",
            "Java",
            "Visual Basic",
            "C++",
            "Embarcadero Pascal",
            "C",
            "Javascript",
            "PHP",
            "Python"});
            this.chlbDiller.Location = new System.Drawing.Point(19, 57);
            this.chlbDiller.Name = "chlbDiller";
            this.chlbDiller.Size = new System.Drawing.Size(146, 184);
            this.chlbDiller.TabIndex = 2;
            // 
            // btonMesaj
            // 
            this.btonMesaj.Location = new System.Drawing.Point(19, 262);
            this.btonMesaj.Name = "btonMesaj";
            this.btonMesaj.Size = new System.Drawing.Size(95, 23);
            this.btonMesaj.TabIndex = 3;
            this.btonMesaj.Text = "Mesaj ver..";
            this.btonMesaj.UseVisualStyleBackColor = true;
            this.btonMesaj.Click += new System.EventHandler(this.btonMesaj_Click);
            // 
            // lbelMessage
            // 
            this.lbelMessage.AutoSize = true;
            this.lbelMessage.Location = new System.Drawing.Point(19, 333);
            this.lbelMessage.Name = "lbelMessage";
            this.lbelMessage.Size = new System.Drawing.Size(38, 15);
            this.lbelMessage.TabIndex = 4;
            this.lbelMessage.Text = "label2";
            // 
            // frmCheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 450);
            this.Controls.Add(this.lbelMessage);
            this.Controls.Add(this.btonMesaj);
            this.Controls.Add(this.chlbDiller);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btonClose);
            this.Name = "frmCheckedListBox";
            this.Text = "frmCheckedListBox";
            this.Load += new System.EventHandler(this.frmCheckedListBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btonClose;
        private Label label1;
        private CheckedListBox chlbDiller;
        private Button btonMesaj;
        private Label lbelMessage;
    }
}