namespace Forms
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
            lbelAd = new Label();
            lbelSoyad = new Label();
            tboxAd = new TextBox();
            tboxSoyad = new TextBox();
            btonGoster = new Button();
            btonExit = new Button();
            SuspendLayout();
            // 
            // lbelAd
            // 
            lbelAd.AutoSize = true;
            lbelAd.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbelAd.Location = new Point(38, 36);
            lbelAd.Name = "lbelAd";
            lbelAd.Size = new Size(43, 32);
            lbelAd.TabIndex = 0;
            lbelAd.Text = "Ad";
            // 
            // lbelSoyad
            // 
            lbelSoyad.AutoSize = true;
            lbelSoyad.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbelSoyad.Location = new Point(38, 100);
            lbelSoyad.Name = "lbelSoyad";
            lbelSoyad.Size = new Size(79, 32);
            lbelSoyad.TabIndex = 1;
            lbelSoyad.Text = "Soyad";
            // 
            // tboxAd
            // 
            tboxAd.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tboxAd.Location = new Point(149, 41);
            tboxAd.Name = "tboxAd";
            tboxAd.Size = new Size(160, 39);
            tboxAd.TabIndex = 2;
            // 
            // tboxSoyad
            // 
            tboxSoyad.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tboxSoyad.Location = new Point(149, 100);
            tboxSoyad.Name = "tboxSoyad";
            tboxSoyad.Size = new Size(160, 39);
            tboxSoyad.TabIndex = 3;
            // 
            // btonGoster
            // 
            btonGoster.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btonGoster.Location = new Point(148, 173);
            btonGoster.Name = "btonGoster";
            btonGoster.Size = new Size(161, 52);
            btonGoster.TabIndex = 4;
            btonGoster.Text = "Göster";
            btonGoster.UseVisualStyleBackColor = true;
            btonGoster.Click += btonGoster_Click;
            // 
            // btonExit
            // 
            btonExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btonExit.Location = new Point(350, 314);
            btonExit.Name = "btonExit";
            btonExit.Size = new Size(94, 29);
            btonExit.TabIndex = 5;
            btonExit.Text = "Çıkış";
            btonExit.UseVisualStyleBackColor = true;
            btonExit.Click += btonExit_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 355);
            ControlBox = false;
            Controls.Add(btonExit);
            Controls.Add(btonGoster);
            Controls.Add(tboxSoyad);
            Controls.Add(tboxAd);
            Controls.Add(lbelSoyad);
            Controls.Add(lbelAd);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbelAd;
        private Label lbelSoyad;
        private TextBox tboxAd;
        private TextBox tboxSoyad;
        private Button btonGoster;
        private Button btonExit;
    }
}
