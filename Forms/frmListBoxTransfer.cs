using System;
using System.Collections;
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
    public partial class frmListBoxTransfer : Form
    {
        public frmListBoxTransfer()
        {
            InitializeComponent();
        }

        #region Ortak Metot
        private void Gonder(ListBox lbSource, ListBox lbDest)
        {
            // Öncelikle acaba lbSource parametresiyle gelen listboxımda aca hangi elemanlar seçilmiş

            try
            {
                ArrayList secilenler = new ArrayList();

                secilenler.AddRange(lbSource.SelectedItems);

                foreach (var item in secilenler)
                {
                    lbDest.Items.Add(item);
                    lbSource.Items.Remove(item);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Tasıma için seçim yapmalısınız.." + e.Message);
            }

        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // source -> dest e tasıyan buton...secılıleri soldan sağa..

            Gonder(lboxSource, lboxDest);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //  source -> dest tasıyor..bir anda hepsini

            foreach (var item in lboxSource.Items)
            {
                lboxDest.Items.Add(item);

            }

            lboxSource.Items.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // dest -> source tasıması sağdan sola tasıma
            Gonder(lboxDest, lboxSource);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // dest -> source tasıma hepsini
            foreach (var item in lboxDest.Items)
            {
                lboxSource.Items.Add(item);

            }

            lboxDest.Items.Clear();

        }
    }
}
