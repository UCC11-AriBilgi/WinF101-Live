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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmSampleFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // İkinci bir form açmak istiyorum

            frmSampleForm frmSampleForm = new frmSampleForm();

            frmSampleForm.Show();
        }

        private void frmCoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCombo frmCombo = new frmCombo();

            frmCombo.ShowDialog();
        }

        private void frmListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListBox frmListBox = new frmListBox();

            frmListBox.ShowDialog();
        }

        private void checkControlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCheckControls frmCheckControls = new frmCheckControls();
            
            frmCheckControls.ShowDialog();
        }

        private void çıkışToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkedListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCheckedListBox frmCheckedListBox=new frmCheckedListBox();

            frmCheckedListBox.ShowDialog();
        }

        private void dateTimePickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDateTimePicker frmDateTimePicker=new frmDateTimePicker();

            frmDateTimePicker.ShowDialog();
        }

        private void timerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimer frmTimer = new frmTimer();

            frmTimer.ShowDialog();
        }
    }
}
