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
    public partial class frmCheckControls : Form
    {
        private RadioButton rb;

        public frmCheckControls()
        {
            InitializeComponent();
        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckControl();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckControl();
        }

        private void CheckControl()
        {
            if (checkBox1.Checked == true)
            {
                if (checkBox2.Checked==true)
                {
                    lbelMessage.Text = "Hem checkbox1 hem de checkbox2 seçili..";
                }
                else
                {
                    lbelMessage.Text = "checkbox1 seçili..";
                }
            }
            else
            {
                if (checkBox2.Checked == true)
                {
                    lbelMessage.Text = "checkbox2 seçili..";
                }
                else
                {
                    lbelMessage.Text = "Ne checkbox1 ne de checkbox2 seçili..";
                }
            }
        }

        private void RadioControl(object sender,EventArgs e)
        {
            rb=(RadioButton)sender;

            if (rb.Checked == true)
            {
                lbelMessage.Text = rb.Name + " seçili";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioControl(sender, e);
        }
    }
}
