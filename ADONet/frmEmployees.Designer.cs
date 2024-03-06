namespace ADONet
{
    partial class frmEmployees
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
            label5 = new Label();
            label6 = new Label();
            tboxEmployeeID = new TextBox();
            tboxCountry = new TextBox();
            tboxCity = new TextBox();
            tboxTitle = new TextBox();
            tboxLName = new TextBox();
            tboxFName = new TextBox();
            btonNext = new Button();
            btonNew = new Button();
            btonInsert = new Button();
            btonUpdate = new Button();
            btonDelete = new Button();
            btonGuncelle = new Button();
            SuspendLayout();
            // 
            // btonClose
            // 
            btonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btonClose.Location = new Point(257, 313);
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
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 1;
            label1.Text = "EmployeeID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 2;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 103);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 3;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 143);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 4;
            label4.Text = "Title";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 177);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 5;
            label5.Text = "City";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 216);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 6;
            label6.Text = "Country";
            // 
            // tboxEmployeeID
            // 
            tboxEmployeeID.Location = new Point(104, 19);
            tboxEmployeeID.Name = "tboxEmployeeID";
            tboxEmployeeID.Size = new Size(100, 23);
            tboxEmployeeID.TabIndex = 7;
            // 
            // tboxCountry
            // 
            tboxCountry.Location = new Point(104, 213);
            tboxCountry.Name = "tboxCountry";
            tboxCountry.Size = new Size(100, 23);
            tboxCountry.TabIndex = 8;
            // 
            // tboxCity
            // 
            tboxCity.Location = new Point(104, 174);
            tboxCity.Name = "tboxCity";
            tboxCity.Size = new Size(100, 23);
            tboxCity.TabIndex = 9;
            // 
            // tboxTitle
            // 
            tboxTitle.Location = new Point(104, 140);
            tboxTitle.Name = "tboxTitle";
            tboxTitle.Size = new Size(100, 23);
            tboxTitle.TabIndex = 10;
            // 
            // tboxLName
            // 
            tboxLName.Location = new Point(104, 100);
            tboxLName.Name = "tboxLName";
            tboxLName.Size = new Size(100, 23);
            tboxLName.TabIndex = 11;
            // 
            // tboxFName
            // 
            tboxFName.Location = new Point(104, 60);
            tboxFName.Name = "tboxFName";
            tboxFName.Size = new Size(100, 23);
            tboxFName.TabIndex = 12;
            // 
            // btonNext
            // 
            btonNext.Location = new Point(259, 18);
            btonNext.Name = "btonNext";
            btonNext.Size = new Size(75, 23);
            btonNext.TabIndex = 13;
            btonNext.Text = "Sonraki";
            btonNext.UseVisualStyleBackColor = true;
            btonNext.Click += btonNext_Click;
            // 
            // btonNew
            // 
            btonNew.Location = new Point(259, 59);
            btonNew.Name = "btonNew";
            btonNew.Size = new Size(75, 23);
            btonNew.TabIndex = 14;
            btonNew.Text = "Yeni";
            btonNew.UseVisualStyleBackColor = true;
            btonNew.Click += btonNew_Click;
            // 
            // btonInsert
            // 
            btonInsert.Location = new Point(14, 278);
            btonInsert.Name = "btonInsert";
            btonInsert.Size = new Size(75, 23);
            btonInsert.TabIndex = 15;
            btonInsert.Text = "Insert";
            btonInsert.UseVisualStyleBackColor = true;
            btonInsert.Click += btonInsert_Click;
            // 
            // btonUpdate
            // 
            btonUpdate.Location = new Point(104, 278);
            btonUpdate.Name = "btonUpdate";
            btonUpdate.Size = new Size(75, 23);
            btonUpdate.TabIndex = 16;
            btonUpdate.Text = "Update";
            btonUpdate.UseVisualStyleBackColor = true;
            btonUpdate.Click += btonUpdate_Click;
            // 
            // btonDelete
            // 
            btonDelete.Location = new Point(196, 278);
            btonDelete.Name = "btonDelete";
            btonDelete.Size = new Size(75, 23);
            btonDelete.TabIndex = 17;
            btonDelete.Text = "Delete";
            btonDelete.UseVisualStyleBackColor = true;
            // 
            // btonGuncelle
            // 
            btonGuncelle.Location = new Point(259, 95);
            btonGuncelle.Name = "btonGuncelle";
            btonGuncelle.Size = new Size(75, 23);
            btonGuncelle.TabIndex = 18;
            btonGuncelle.Text = "Güncelle";
            btonGuncelle.UseVisualStyleBackColor = true;
            btonGuncelle.Click += btonGuncelle_Click;
            // 
            // frmEmployees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 348);
            Controls.Add(btonGuncelle);
            Controls.Add(btonDelete);
            Controls.Add(btonUpdate);
            Controls.Add(btonInsert);
            Controls.Add(btonNew);
            Controls.Add(btonNext);
            Controls.Add(tboxFName);
            Controls.Add(tboxLName);
            Controls.Add(tboxTitle);
            Controls.Add(tboxCity);
            Controls.Add(tboxCountry);
            Controls.Add(tboxEmployeeID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btonClose);
            Name = "frmEmployees";
            Text = "frmEmployees";
            Load += frmEmployees_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btonClose;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tboxEmployeeID;
        private TextBox tboxCountry;
        private TextBox tboxCity;
        private TextBox tboxTitle;
        private TextBox tboxLName;
        private TextBox tboxFName;
        private Button btonNext;
        private Button btonNew;
        private Button btonInsert;
        private Button btonUpdate;
        private Button btonDelete;
        private Button btonGuncelle;
    }
}