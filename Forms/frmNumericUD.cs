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
    public partial class frmNumericUD : Form
    {
        public frmNumericUD()
        {
            InitializeComponent();
        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNumericUD_Load(object sender, EventArgs e)
        {
            nudMiktar.Maximum = 1000;
        }

        private void btonIslem_Click(object sender, EventArgs e)
        {
            int sonuc = Convert.ToInt32(lbelSonuc.Text); // içeriği sayıya cevirdim

            int miktar = Convert.ToInt32(nudMiktar.Value); //nud içeriği sayısal aldım

            if (radioButton1.Checked == true)
            {
                lbelSonuc.Text = (sonuc + miktar).ToString();
            }

            if (radioButton2.Checked == true)
            {
                lbelSonuc.Text = (sonuc - miktar).ToString();
            }





        }
    }
}
