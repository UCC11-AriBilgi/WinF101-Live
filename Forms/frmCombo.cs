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
            this.Close();
        }

        private void btonGoster_Click(object sender, EventArgs e)
        {
            string sehir = cboxListe.Items[cboxListe.SelectedIndex].ToString();

            MessageBox.Show($"Seçmiş olduğunuz şehir : {sehir} dir");

            cboxListe.SelectedIndex = 0; // ilk eleman

        }

        private void frmCombo_Load(object sender, EventArgs e)
        {
            cboxListe.SelectedIndex = 0; // ilk eleman gösterecek haline getirildi.
        }

        private void cboxHangi_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Öncelikle 2. comboyu bir temizliyorum. önceki duranları temizliyorum.
            cboxSonuc.Items.Clear();
            cboxSonuc.Text = "";

            string secilen=(string)cboxHangi.SelectedItem; // combonun seçilen text i

            if (secilen == "Haftanın Günleri")
            {
                // önce bir dizi yarat...manuel olarak içini doldur.
                string[] gunler = { "Pzt", "Sal", "Çar", "Per", "Cum", "Cmt", "Paz" };

                cboxSonuc.Items.AddRange(gunler); // Çoklu ekleme
            }
            else
            {
                // önce bir dizi yarat...manuel olarak içini doldur.
                string[] yillar = { "2020", "2021", "2022", "2023", "2024", "2025", "2026" };

                cboxSonuc.Items.AddRange(yillar);
            }

            cboxSonuc.SelectedIndex = 0; // ilk elemana konumlanma
        }
    }
}
