using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class frmCombo : Form
    {
        public frmCombo()
        {
            InitializeComponent();
        }

        private void btonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btonGoster_Click(object sender, EventArgs e)
        {
            string sehir = cboxListe.Items[cboxListe.SelectedIndex].ToString();

            MessageBox.Show($"Seçmiş olduğunuz şehir : {sehir} dir");

            cboxListe.SelectedIndex = 0; // ilk eleman

        }

        private void frmCombo_Load(object sender, EventArgs e)
        {
            cboxListe.SelectedIndex = 0;
        }
    }
}
