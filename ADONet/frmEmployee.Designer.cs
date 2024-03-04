namespace ADONet
{
    partial class frmEmployee
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
            tboxAd = new TextBox();
            label2 = new Label();
            tboxSoyad = new TextBox();
            label3 = new Label();
            tboxSehir = new TextBox();
            btonNew = new Button();
            btonUpdate = new Button();
            btonDelete = new Button();
            SuspendLayout();
            // 
            // btonClose
            // 
            btonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btonClose.Location = new Point(205, 231);
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
            label1.Location = new Point(33, 26);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 1;
            label1.Text = "Ad";
            // 
            // tboxAd
            // 
            tboxAd.Location = new Point(93, 23);
            tboxAd.Name = "tboxAd";
            tboxAd.Size = new Size(100, 23);
            tboxAd.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 65);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Soyad";
            // 
            // tboxSoyad
            // 
            tboxSoyad.Location = new Point(93, 62);
            tboxSoyad.Name = "tboxSoyad";
            tboxSoyad.Size = new Size(100, 23);
            tboxSoyad.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 109);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 5;
            label3.Text = "Şehir";
            // 
            // tboxSehir
            // 
            tboxSehir.Location = new Point(93, 106);
            tboxSehir.Name = "tboxSehir";
            tboxSehir.Size = new Size(100, 23);
            tboxSehir.TabIndex = 6;
            // 
            // btonNew
            // 
            btonNew.Location = new Point(12, 171);
            btonNew.Name = "btonNew";
            btonNew.Size = new Size(43, 23);
            btonNew.TabIndex = 7;
            btonNew.Text = "Yeni";
            btonNew.UseVisualStyleBackColor = true;
            btonNew.Click += btonNew_Click;
            // 
            // btonUpdate
            // 
            btonUpdate.Location = new Point(61, 171);
            btonUpdate.Name = "btonUpdate";
            btonUpdate.Size = new Size(52, 23);
            btonUpdate.TabIndex = 8;
            btonUpdate.Text = "Günc.";
            btonUpdate.UseVisualStyleBackColor = true;
            // 
            // btonDelete
            // 
            btonDelete.Location = new Point(119, 171);
            btonDelete.Name = "btonDelete";
            btonDelete.Size = new Size(39, 23);
            btonDelete.TabIndex = 9;
            btonDelete.Text = "Sil";
            btonDelete.UseVisualStyleBackColor = true;
            // 
            // frmEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 266);
            Controls.Add(btonDelete);
            Controls.Add(btonUpdate);
            Controls.Add(btonNew);
            Controls.Add(tboxSehir);
            Controls.Add(label3);
            Controls.Add(tboxSoyad);
            Controls.Add(label2);
            Controls.Add(tboxAd);
            Controls.Add(label1);
            Controls.Add(btonClose);
            Name = "frmEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEmployee";
            Load += frmEmployee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btonClose;
        private Label label1;
        private TextBox tboxAd;
        private Label label2;
        private TextBox tboxSoyad;
        private Label label3;
        private TextBox tboxSehir;
        private Button btonNew;
        private Button btonUpdate;
        private Button btonDelete;
    }
}