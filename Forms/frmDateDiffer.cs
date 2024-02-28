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
    public partial class frmDateDiffer : Form
    {
        public frmDateDiffer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // end-start

            DateTime startDate = Convert.ToDateTime(dtpStart.Text);

            DateTime endDate = Convert.ToDateTime(dtpEnd.Text);

            TimeSpan sonuc = endDate.Subtract(startDate); // enddate-startdate

            string Year = Convert.ToString(Math.Round(sonuc.TotalDays / 365, 3)) + " Yıl veya";

            string Mounth = Convert.ToString(Math.Round(sonuc.TotalDays / 30, 2)) + " Ay veya";

            string Day=Convert.ToString(Math.Round(sonuc.TotalDays,2)) + " Gün veya";

            string Hour = Convert.ToString(Math.Round(sonuc.TotalHours, 2)) + " Saat veya";

            string Minute = Convert.ToString(Math.Round(sonuc.TotalMinutes, 2)) + " Dakika";

            lboxResult.Items.Clear();

            lboxResult.Items.Add(Year);
            lboxResult.Items.Add(Mounth);
            lboxResult.Items.Add(Day);
            lboxResult.Items.Add(Hour);
            lboxResult.Items.Add(Minute);



        }
    }
}
