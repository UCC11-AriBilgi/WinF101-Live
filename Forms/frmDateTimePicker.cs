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
    public partial class frmDateTimePicker : Form
    {
        public frmDateTimePicker()
        {
            InitializeComponent();
        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btonGoster_Click(object sender, EventArgs e)
        {
            DateTime dgun = new DateTime();

            dgun = dtpCalendar.Value;

            int dYil=dgun.Year; // dtpCalendar.Value.Year
            int dAy = dgun.Month;
            int dGun=dgun.Day;

            int buYil=DateTime.Now.Year; // şu anki yıl 

            int yas = buYil - dYil;

            MessageBox.Show($"Sayın {tboxAdSoyad.Text} - Siz {dYil} yılının {dAy} ayının {dGun}. gününde doğmuşsunuz..Yaşınız {yas} dır.. ");

        }
    }
}
