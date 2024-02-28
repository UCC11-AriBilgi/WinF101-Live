namespace Forms
{
    partial class frmNumericUD
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
            nudMiktar = new NumericUpDown();
            label1 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            btonIslem = new Button();
            label2 = new Label();
            lbelSonuc = new Label();
            ((System.ComponentModel.ISupportInitialize)nudMiktar).BeginInit();
            SuspendLayout();
            // 
            // btonClose
            // 
            btonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btonClose.Location = new Point(315, 184);
            btonClose.Name = "btonClose";
            btonClose.Size = new Size(75, 23);
            btonClose.TabIndex = 0;
            btonClose.Text = "Kapat";
            btonClose.UseVisualStyleBackColor = true;
            btonClose.Click += btonClose_Click;
            // 
            // nudMiktar
            // 
            nudMiktar.Location = new Point(56, 53);
            nudMiktar.Name = "nudMiktar";
            nudMiktar.Size = new Size(52, 23);
            nudMiktar.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 24);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 2;
            label1.Text = "Miktar";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(56, 105);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(52, 19);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Arttır";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(139, 105);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(51, 19);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "Azalt";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // btonIslem
            // 
            btonIslem.Location = new Point(56, 166);
            btonIslem.Name = "btonIslem";
            btonIslem.Size = new Size(75, 23);
            btonIslem.TabIndex = 5;
            btonIslem.Text = "İşlem Yap";
            btonIslem.UseVisualStyleBackColor = true;
            btonIslem.Click += btonIslem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(258, 105);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 6;
            label2.Text = "Sonuç :";
            // 
            // lbelSonuc
            // 
            lbelSonuc.AutoSize = true;
            lbelSonuc.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbelSonuc.Location = new Point(363, 105);
            lbelSonuc.Name = "lbelSonuc";
            lbelSonuc.Size = new Size(23, 25);
            lbelSonuc.TabIndex = 7;
            lbelSonuc.Text = "0";
            // 
            // frmNumericUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 219);
            Controls.Add(lbelSonuc);
            Controls.Add(label2);
            Controls.Add(btonIslem);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Controls.Add(nudMiktar);
            Controls.Add(btonClose);
            Name = "frmNumericUD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmNumericUD";
            Load += frmNumericUD_Load;
            ((System.ComponentModel.ISupportInitialize)nudMiktar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btonClose;
        private NumericUpDown nudMiktar;
        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button btonIslem;
        private Label label2;
        private Label lbelSonuc;
    }
}