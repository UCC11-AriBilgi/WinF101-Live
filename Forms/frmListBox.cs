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
    public partial class frmListBox : Form
    {
        public frmListBox()
        {
            InitializeComponent();
        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btonEkle_Click(object sender, EventArgs e)
        {
            lboxSayilar.Items.Add(tboxSayi.Text);

            tboxSayi.Clear();

            tboxSayi.Focus();
        }

        private void btonHesapla_Click(object sender, EventArgs e)
        {
            double toplam = 0;
            double ortalama = 0;

            for (int i = 0; i < lboxSayilar.Items.Count; i++)
            {
                toplam += Convert.ToDouble(lboxSayilar.Items[i]);
            }

            ortalama = toplam / lboxSayilar.Items.Count;

            tboxToplam.Text = toplam.ToString();

            tboxOrtalama.Text = String.Format("{0:0.000}",ortalama);

            // just two decimal places
            //String.Format("{0:0.00}", 123.4567);      // "123.46"
            //String.Format("{0:0.00}", 123.4);         // "123.40"
            //String.Format("{0:0.00}", 123.0);         // "123.00"

            // max. two decimal places
            //String.Format("{0:0.##}", 123.4567);      // "123.46"
            //String.Format("{0:0.##}", 123.4);         // "123.4"
            //String.Format("{0:0.##}", 123.0);         // "123"

        }

        private void btonTemizle_Click(object sender, EventArgs e)
        {
            lboxSayilar.Items.Clear();

            tboxOrtalama.Clear();

            tboxToplam.Clear();
        }
    }
}
