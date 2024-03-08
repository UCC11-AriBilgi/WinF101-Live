namespace ADONet
{
    partial class frmCustomers
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
            dgrdCustomers = new DataGridView();
            btonAdd = new Button();
            btonUpdate = new Button();
            btonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgrdCustomers).BeginInit();
            SuspendLayout();
            // 
            // btonClose
            // 
            btonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btonClose.Location = new Point(1097, 582);
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
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(23, 21);
            label1.Name = "label1";
            label1.Size = new Size(195, 32);
            label1.TabIndex = 1;
            label1.Text = "Customers Data";
            // 
            // dgrdCustomers
            // 
            dgrdCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrdCustomers.Location = new Point(32, 78);
            dgrdCustomers.Name = "dgrdCustomers";
            dgrdCustomers.RowHeadersWidth = 51;
            dgrdCustomers.Size = new Size(1143, 393);
            dgrdCustomers.TabIndex = 2;
            // 
            // btonAdd
            // 
            btonAdd.Location = new Point(32, 499);
            btonAdd.Name = "btonAdd";
            btonAdd.Size = new Size(94, 29);
            btonAdd.TabIndex = 3;
            btonAdd.Text = "Ekle";
            btonAdd.UseVisualStyleBackColor = true;
            btonAdd.Click += btonAdd_Click;
            // 
            // btonUpdate
            // 
            btonUpdate.Location = new Point(150, 499);
            btonUpdate.Name = "btonUpdate";
            btonUpdate.Size = new Size(94, 29);
            btonUpdate.TabIndex = 4;
            btonUpdate.Text = "Güncelle";
            btonUpdate.UseVisualStyleBackColor = true;
            btonUpdate.Click += btonUpdate_Click;
            // 
            // btonDelete
            // 
            btonDelete.Location = new Point(272, 499);
            btonDelete.Name = "btonDelete";
            btonDelete.Size = new Size(94, 29);
            btonDelete.TabIndex = 5;
            btonDelete.Text = "Sil";
            btonDelete.UseVisualStyleBackColor = true;
            // 
            // frmCustomers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1203, 623);
            Controls.Add(btonDelete);
            Controls.Add(btonUpdate);
            Controls.Add(btonAdd);
            Controls.Add(dgrdCustomers);
            Controls.Add(label1);
            Controls.Add(btonClose);
            Name = "frmCustomers";
            Text = "frmCustomers";
            Load += frmCustomers_Load;
            ((System.ComponentModel.ISupportInitialize)dgrdCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btonClose;
        private Label label1;
        private DataGridView dgrdCustomers;
        private Button btonAdd;
        private Button btonUpdate;
        private Button btonDelete;
    }
}