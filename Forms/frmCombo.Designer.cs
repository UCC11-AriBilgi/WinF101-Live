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
            cboxListe = new ComboBox();
            btonGoster = new Button();
            btonExit = new Button();
            SuspendLayout();
            // 
            // cboxListe
            // 
            cboxListe.FormattingEnabled = true;
            cboxListe.Items.AddRange(new object[] { resources.GetString("cboxListe.Items"), resources.GetString("cboxListe.Items1"), resources.GetString("cboxListe.Items2"), resources.GetString("cboxListe.Items3"), resources.GetString("cboxListe.Items4"), resources.GetString("cboxListe.Items5") });
            resources.ApplyResources(cboxListe, "cboxListe");
            cboxListe.Name = "cboxListe";
            // 
            // btonGoster
            // 
            resources.ApplyResources(btonGoster, "btonGoster");
            btonGoster.Name = "btonGoster";
            btonGoster.UseVisualStyleBackColor = true;
            btonGoster.Click += btonGoster_Click;
            // 
            // btonExit
            // 
            resources.ApplyResources(btonExit, "btonExit");
            btonExit.Name = "btonExit";
            btonExit.UseVisualStyleBackColor = true;
            btonExit.Click += btonExit_Click;
            // 
            // frmCombo
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            ControlBox = false;
            Controls.Add(btonExit);
            Controls.Add(btonGoster);
            Controls.Add(cboxListe);
            Name = "frmCombo";
            Load += frmCombo_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cboxListe;
        private Button btonGoster;
        private Button btonExit;
    }
}