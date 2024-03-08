namespace ADONet
{
    partial class frmCustomerDetails
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tboxCustomerID = new TextBox();
            tboxCompanyName = new TextBox();
            tboxContactName = new TextBox();
            tboxCountry = new TextBox();
            btonSave = new Button();
            SuspendLayout();
            // 
            // btonClose
            // 
            btonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btonClose.Location = new Point(405, 240);
            btonClose.Name = "btonClose";
            btonClose.Size = new Size(94, 29);
            btonClose.TabIndex = 0;
            btonClose.Text = "Kapat";
            btonClose.UseVisualStyleBackColor = true;
            btonClose.Click += btonClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 27);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 1;
            label1.Text = "CustomerID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 60);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 2;
            label2.Text = "Company Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 93);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 3;
            label3.Text = "Contact Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 126);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 4;
            label4.Text = "Country";
            // 
            // tboxCustomerID
            // 
            tboxCustomerID.Enabled = false;
            tboxCustomerID.Location = new Point(181, 24);
            tboxCustomerID.Name = "tboxCustomerID";
            tboxCustomerID.Size = new Size(125, 27);
            tboxCustomerID.TabIndex = 5;
            // 
            // tboxCompanyName
            // 
            tboxCompanyName.Location = new Point(181, 57);
            tboxCompanyName.Name = "tboxCompanyName";
            tboxCompanyName.Size = new Size(308, 27);
            tboxCompanyName.TabIndex = 6;
            // 
            // tboxContactName
            // 
            tboxContactName.Location = new Point(181, 90);
            tboxContactName.Name = "tboxContactName";
            tboxContactName.Size = new Size(234, 27);
            tboxContactName.TabIndex = 7;
            // 
            // tboxCountry
            // 
            tboxCountry.Location = new Point(181, 123);
            tboxCountry.Name = "tboxCountry";
            tboxCountry.Size = new Size(125, 27);
            tboxCountry.TabIndex = 8;
            // 
            // btonSave
            // 
            btonSave.Location = new Point(181, 179);
            btonSave.Name = "btonSave";
            btonSave.Size = new Size(94, 29);
            btonSave.TabIndex = 9;
            btonSave.Text = "Kaydet";
            btonSave.UseVisualStyleBackColor = true;
            btonSave.Click += btonSave_Click;
            // 
            // frmCustomerDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 281);
            Controls.Add(btonSave);
            Controls.Add(tboxCountry);
            Controls.Add(tboxContactName);
            Controls.Add(tboxCompanyName);
            Controls.Add(tboxCustomerID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btonClose);
            Name = "frmCustomerDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCustomerDetails";
            Load += frmCustomerDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btonClose;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btonSave;
        public TextBox tboxCustomerID;
        public TextBox tboxCompanyName;
        public TextBox tboxContactName;
        public TextBox tboxCountry;
    }
}