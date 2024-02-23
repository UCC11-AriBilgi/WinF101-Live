namespace Forms
{
    partial class frmListBox
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
            lboxSayilar = new ListBox();
            label1 = new Label();
            tboxSayi = new TextBox();
            btonEkle = new Button();
            btonHesapla = new Button();
            label2 = new Label();
            label3 = new Label();
            tboxToplam = new TextBox();
            tboxOrtalama = new TextBox();
            btonTemizle = new Button();
            SuspendLayout();
            // 
            // btonClose
            // 
            btonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btonClose.Location = new Point(478, 435);
            btonClose.Name = "btonClose";
            btonClose.Size = new Size(94, 29);
            btonClose.TabIndex = 0;
            btonClose.Text = "Kapat";
            btonClose.UseVisualStyleBackColor = true;
            btonClose.Click += btonClose_Click;
            // 
            // lboxSayilar
            // 
            lboxSayilar.FormattingEnabled = true;
            lboxSayilar.ItemHeight = 20;
            lboxSayilar.Location = new Point(115, 81);
            lboxSayilar.Name = "lboxSayilar";
            lboxSayilar.Size = new Size(150, 164);
            lboxSayilar.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 30);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 2;
            label1.Text = "Sayı";
            // 
            // tboxSayi
            // 
            tboxSayi.Location = new Point(115, 30);
            tboxSayi.Name = "tboxSayi";
            tboxSayi.Size = new Size(125, 27);
            tboxSayi.TabIndex = 3;
            // 
            // btonEkle
            // 
            btonEkle.Location = new Point(284, 29);
            btonEkle.Name = "btonEkle";
            btonEkle.Size = new Size(94, 29);
            btonEkle.TabIndex = 4;
            btonEkle.Text = "Ekle";
            btonEkle.UseVisualStyleBackColor = true;
            btonEkle.Click += btonEkle_Click;
            // 
            // btonHesapla
            // 
            btonHesapla.Location = new Point(115, 277);
            btonHesapla.Name = "btonHesapla";
            btonHesapla.Size = new Size(94, 29);
            btonHesapla.TabIndex = 5;
            btonHesapla.Text = "Hesapla";
            btonHesapla.UseVisualStyleBackColor = true;
            btonHesapla.Click += btonHesapla_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 346);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 6;
            label2.Text = "Toplam";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(159, 388);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 7;
            label3.Text = "Ortalama";
            // 
            // tboxToplam
            // 
            tboxToplam.Enabled = false;
            tboxToplam.Location = new Point(242, 343);
            tboxToplam.Name = "tboxToplam";
            tboxToplam.Size = new Size(125, 27);
            tboxToplam.TabIndex = 8;
            // 
            // tboxOrtalama
            // 
            tboxOrtalama.Enabled = false;
            tboxOrtalama.Location = new Point(242, 388);
            tboxOrtalama.Name = "tboxOrtalama";
            tboxOrtalama.Size = new Size(125, 27);
            tboxOrtalama.TabIndex = 9;
            // 
            // btonTemizle
            // 
            btonTemizle.Location = new Point(273, 143);
            btonTemizle.Name = "btonTemizle";
            btonTemizle.Size = new Size(94, 29);
            btonTemizle.TabIndex = 10;
            btonTemizle.Text = "Temizle";
            btonTemizle.UseVisualStyleBackColor = true;
            btonTemizle.Click += btonTemizle_Click;
            // 
            // frmListBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 476);
            Controls.Add(btonTemizle);
            Controls.Add(tboxOrtalama);
            Controls.Add(tboxToplam);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btonHesapla);
            Controls.Add(btonEkle);
            Controls.Add(tboxSayi);
            Controls.Add(label1);
            Controls.Add(lboxSayilar);
            Controls.Add(btonClose);
            Name = "frmListBox";
            Text = "frmListBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btonClose;
        private ListBox lboxSayilar;
        private Label label1;
        private TextBox tboxSayi;
        private Button btonEkle;
        private Button btonHesapla;
        private Label label2;
        private Label label3;
        private TextBox tboxToplam;
        private TextBox tboxOrtalama;
        private Button btonTemizle;
    }
}