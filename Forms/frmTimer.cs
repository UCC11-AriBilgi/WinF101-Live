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
    public partial class frmTimer : Form
    {
        public frmTimer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTimer_Load(object sender, EventArgs e)
        {
            // forma girer girmez güncel s d sn göstersin

            int Saat = DateTime.Now.Hour;
            int Dakika= DateTime.Now.Minute;
            int Saniye = DateTime.Now.Second;

            lbelSaat.Text= Saat + ":" + Dakika + ":" + Saniye;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Interval= 100; // her saniye

            timer1.Enabled= true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int Saat = DateTime.Now.Hour;
            int Dakika = DateTime.Now.Minute;
            int Saniye = DateTime.Now.Second;

            lbelSaat.Text = Saat + ":" + Dakika + ":" + Saniye;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled=false;
        }
    }
}
