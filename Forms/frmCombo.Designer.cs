namespace Forms
{
    partial class frmCombo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCombo));
            this.cboxListe = new System.Windows.Forms.ComboBox();
            this.btonGoster = new System.Windows.Forms.Button();
            this.btonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxHangi = new System.Windows.Forms.ComboBox();
            this.cboxSonuc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboxListe
            // 
            this.cboxListe.FormattingEnabled = true;
            this.cboxListe.Items.AddRange(new object[] {
            resources.GetString("cboxListe.Items"),
            resources.GetString("cboxListe.Items1"),
            resources.GetString("cboxListe.Items2"),
            resources.GetString("cboxListe.Items3"),
            resources.GetString("cboxListe.Items4"),
            resources.GetString("cboxListe.Items5")});
            resources.ApplyResources(this.cboxListe, "cboxListe");
            this.cboxListe.Name = "cboxListe";
            // 
            // btonGoster
            // 
            resources.ApplyResources(this.btonGoster, "btonGoster");
            this.btonGoster.Name = "btonGoster";
            this.btonGoster.UseVisualStyleBackColor = true;
            // 
            // btonExit
            // 
            resources.ApplyResources(this.btonExit, "btonExit");
            this.btonExit.Name = "btonExit";
            this.btonExit.UseVisualStyleBackColor = true;
            this.btonExit.Click += new System.EventHandler(this.btonExit_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cboxHangi
            // 
            this.cboxHangi.FormattingEnabled = true;
            this.cboxHangi.Items.AddRange(new object[] {
            resources.GetString("cboxHangi.Items"),
            resources.GetString("cboxHangi.Items1")});
            resources.ApplyResources(this.cboxHangi, "cboxHangi");
            this.cboxHangi.Name = "cboxHangi";
            this.cboxHangi.SelectedIndexChanged += new System.EventHandler(this.cboxHangi_SelectedIndexChanged);
            // 
            // cboxSonuc
            // 
            this.cboxSonuc.FormattingEnabled = true;
            resources.ApplyResources(this.cboxSonuc, "cboxSonuc");
            this.cboxSonuc.Name = "cboxSonuc";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // frmCombo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboxSonuc);
            this.Controls.Add(this.cboxHangi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btonExit);
            this.Controls.Add(this.btonGoster);
            this.Controls.Add(this.cboxListe);
            this.Name = "frmCombo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cboxListe;
        private Button btonGoster;
        private Button btonExit;
        private Label label1;
        private ComboBox cboxHangi;
        private ComboBox cboxSonuc;
        private Label label2;
    }
}